using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ImageMagick;

namespace ComicEditor
{
    
    public partial class Form1 : Form
    {
        public static string comicPath = "";
        string[] files;
        public int currentPage = 0;
        public string currentPagePath = "";
        public int currentPanel = 1;
        int cropX;
        int cropY;
        int cropX2;
        int cropY2;
        int cropWidth;
        int cropHeight;
        public int maxWidth = 0;
        public int maxHeight = 0;
        public Pen cropPen = new Pen(Color.Yellow, 1);
        public DashStyle cropDashStyle = DashStyle.DashDot;
        public Color lineColor = Color.Red;
        public Brush TextColor = Brushes.LawnGreen;
        Comic comic;
        public Form1()
        {
            InitializeComponent();
            TopMost=true;
            comic = new Comic();
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            folderBrowserDialog1.ShowDialog();
            comicPath = folderBrowserDialog1.SelectedPath;
            LoadComic(folderBrowserDialog1.SelectedPath);
        }

        public void LoadComic(string path)
        {
            bool jsonPresent = false;
            List<string> lstPaths = Directory.GetFiles(path).ToList();
            List<string> lstPages = new List<string>();
            foreach (string f in lstPaths)
            {
                if (f.Contains(".jpg") || f.Contains(".jpeg"))
                {
                    lstPages.Add(f);
                }
                else if (f.Contains(".json"))
                {
                    jsonPresent = true;
                }
            }
            files = lstPages.ToArray();
            int index = 0;
            lblPageNumber.Text = "Page: " + (currentPage + 1);
            Dictionary<string, string> coordinates = new Dictionary<string, string>();
            if ((!lstPages[0].EndsWith("jpeg")) && (!lstPages[0].EndsWith("jpg")))
            {
                index++;
            }
            Image image = Image.FromFile(lstPages[index]);
            panel5.Width = image.Width / 3;
            panel5.Height = image.Height / 3;
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height / 3;
            pictureBox1.Width = image.Width / 3;
            pictureBoxTextColor.BackColor = Color.LawnGreen;
            pictureBoxLineColor.BackColor = lineColor;
            pictureBoxToolColor.BackColor = Color.Yellow;
            currentPage = 0;
            if (jsonPresent == false)
            {
                int pageCounter = 1;
                foreach (string jpg in lstPages)
                {
                    if (!jpg.EndsWith(".json") || !jpg.EndsWith(".db") || !jpg.EndsWith(".pdf"))
                    {
                        Panel panel = new Panel();
                        Page page = new Page();
                        FileInfo fi = new FileInfo(jpg);
                        panel.page_number = pageCounter;
                        panel.panel_number = 1;
                        panel.x1 = 0;
                        panel.y1 = 0;
                        panel.x2 = image.Width;
                        panel.y2 = image.Height;
                        maxWidth = image.Width;
                        maxHeight = image.Height;
                        page.panels.Add(panel);
                        int indexofUnderscore = fi.Name.IndexOf("_") + 1;
                        string fileName = fi.Name.Substring(indexofUnderscore);
                        page.file_name = fileName.Remove(fileName.IndexOf("."), fileName.Length - fileName.IndexOf("."));
                        page.file_name = "comic" + page.file_name;
                        page.page_number = pageCounter;
                        pageCounter++;
                        comic.pages.Add(page);
                    }
                }
            }
            else
            {
                loadJSON(Path.Combine(path, "comic.json"));
            }
        }

        private void SelectPanel()
        {
            if (comic.pages[currentPage] == null)
            {
                currentPanel = 1;
            }
            else
            {
                currentPanel = comic.pages[currentPage].panels.Count;
            }
            currentPanel++;
            comic.pages[currentPage] = comic.pages[currentPage];
            Panel pInfo = new Panel();
            pInfo.page_number = currentPage + 1;
            pInfo.panel_number = currentPanel;
            pInfo.x1 = cropX;
            pInfo.y1 = cropY;
            pInfo.x2 = cropX2;
            pInfo.y2 = cropY2;
            comic.pages[currentPage].panels.Add(pInfo);
            comic.pages[currentPage] = comic.pages[currentPage];
            pictureBox1.Refresh();
            DrawRectangles(currentPage);
            WriteJson();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectPanel();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ///
            Point mousePos = e.Location;
            ///try to multiply the x/y by what i've devided the picturebox resolution by (3)

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                cropX = e.X;
                cropY = e.Y;
                cropPen.DashStyle = DashStyle.DashDotDot;
                pictureBox1.Refresh();
            }
            if (e.Button == MouseButtons.Right)
            {
                SelectPanel();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox1.Refresh();
                cropWidth = e.X - cropX;
                cropHeight = e.Y - cropY;
                cropX2 = e.X;
                cropY2 = e.Y;
                pictureBox1.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            changePage(1);
        }

        private void changePage(int direction)
        {
            //commit panel edits for the page to the comic object
            //comic.pages[currentPage] = page;
            currentPage = currentPage + direction;
            if (currentPage > comic.pages.Count)
            {
                currentPage--;
            }
            else if (currentPage < 0)
            {
                currentPage++;
            }
            pictureBox1.Image = Image.FromFile(files[currentPage]);
            currentPagePath = files[currentPage];
            lblPageNumber.Text = "Page: " + (currentPage + 1);
            currentPanel = comic.pages[currentPage].panels.Count;
            pictureBox1.Refresh();
            DrawRectangles(currentPage);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            changePage(-1);
        }
        public void DrawRectangles(int pageIndex)
        {
            Font myFont = new Font("Arial", 22);
            List<RectangleF> rects = new List<RectangleF>();
            RectangleF rect = new Rectangle();
            Page page = comic.pages[pageIndex];
            List<Panel> panels = page.panels;
            List<string> labelPositions = new List<string>();
            foreach (Panel panel in panels)
            {
                if (panel.panel_number != 1)
                {
                    rect.X = panel.x1;
                    rect.Y = panel.y1;
                    rect.Width = panel.x2 - panel.x1;
                    rect.Height = panel.y2 - panel.y1;
                    rects.Add(rect);
                }
            }
            Pen pen = new Pen(lineColor, 3);
            pen.DashStyle = DashStyle.Solid;
            RectangleF[] rectArray = rects.ToArray();
            int displayNum = 1;
            foreach (RectangleF label in rects)
            {
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
                pictureBox1.CreateGraphics().DrawString(displayNum.ToString(), myFont, TextColor, label);
                displayNum++;
            }
            if (rectArray.Length != 0)
            {
                pictureBox1.CreateGraphics().DrawRectangles(pen, rectArray);
            }
        }

        private void RefreshPage(int pageNum)
        {
            Page page = comic.pages[pageNum];
            List<Panel> panels = page.panels;
            foreach (Panel panel in panels.ToList())
            {
                if (panel.panel_number != 1)
                {
                    panels.Remove(panel);
                    page.panels = panels;
                }
            }
            pictureBox1.Refresh();
            DrawRectangles(pageNum);
        }

        private void UndoLastPanel(int pageNum)
        {
            Page page = comic.pages[pageNum];
            List<Panel> panels = page.panels;
            int panelCount = panels.Count;
            foreach (Panel panel in panels.ToList())
            {
                if (panel.panel_number != 1 && panel.panel_number == panelCount)
                {
                    panels.Remove(panel);
                    page.panels = panels;
                }
            }
            pictureBox1.Refresh();
            DrawRectangles(pageNum);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPage(currentPage);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            UndoLastPanel(currentPage);
        }

        private void btnLineColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                lineColor = colorDialog1.Color;
                pictureBoxLineColor.BackColor = lineColor;
                pictureBox1.Refresh();
                DrawRectangles(currentPage);
            }
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextColor = new SolidBrush(colorDialog1.Color);
                pictureBoxTextColor.BackColor = colorDialog1.Color;
                pictureBox1.Refresh();
                DrawRectangles(currentPage);
            }
        }

        private void selectComicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            comicPath = folderBrowserDialog1.SelectedPath;
            
            LoadComic(comicPath);
        }

        private void finalizeComicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteJson();
        }

        private void WriteJson()
        {
            foreach (Page page in comic.pages)
            {
                foreach (Panel panel in page.panels)
                {
                    //panel 1 will always be a macro shot of (0,0)x(image.height,image.width), so omit it from the scaling loop
                    if (panel.panel_number != 1)
                    {
                        panel.x1 = panel.x1 * 3;
                        if (panel.x1 > maxWidth)
                        {
                            panel.x1 = maxWidth;
                        }
                        panel.y1 = panel.y1 * 3;
                        if (panel.y1 > maxHeight)
                        {
                            panel.y1 = maxHeight;
                        }
                        panel.x2 = panel.x2 * 3;
                        if (panel.x2 > maxWidth)
                        {
                            panel.x2 = maxWidth;
                        }
                        panel.y2 = panel.y2 * 3;
                        if (panel.y2 > maxHeight)
                        {
                            panel.y2 = maxHeight;
                        }
                    }
                }
            }
            comic.artist = textBoxArtist.Text;
            comic.date = textBoxDate.Text;
            comic.author = textBoxAuthor.Text;
            comic.publisher = textBoxPublisher.Text;
            comic.genre = textBoxGenre.Text;
            comic.summary = textBoxSummary.Text;
            string jsonPath = Path.Combine(comicPath, "comic.json");
            FileInfo fi = new FileInfo(comicPath);
            if (fi.Exists)
            {
                fi.Delete();
            }
            string sanitized = JsonConvert.SerializeObject(comic, Formatting.Indented);
            File.WriteAllText(jsonPath, sanitized);
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                UndoLastPanel(currentPage);
                MessageBox.Show("YAY");
            }
        }

        private void btnToolColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            cropPen = new Pen(colorDialog1.Color);
            pictureBoxToolColor.BackColor = colorDialog1.Color;
            pictureBoxToolColor.Refresh();
        }

        private void showMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == true)
            {
                panel4.Visible = false;
                panel4.Refresh();
            }
            else if (panel4.Visible == false)
            {
                panel4.Visible = true;
                panel4.Refresh();
            }
        }

        private void editComicMetadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelMetadata.Visible == false)
            {
                panelMetadata.Visible = true;
            }
        }

        private void buttonHideMetadata_Click(object sender, EventArgs e)
        {
            if (panelMetadata.Visible == true)
            {
                panelMetadata.Visible = false;
            }
        }

        private void loadJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filepath = openFileDialog1.FileName;
            loadJSON(filepath);
        }

        public void loadJSON(string jsonPath)
        {
            comic = JsonConvert.DeserializeObject<Comic>(File.ReadAllText(jsonPath));
            foreach(Page pg in comic.pages)
            {
                foreach (Panel pn in pg.panels)
                {
                    if (pn.panel_number != 1)
                    {
                        pn.x1 = pn.x1 / 3;
                        pn.y1 = pn.y1 / 3;
                        pn.x2 = pn.x2 / 3;
                        pn.y2 = pn.y2 / 3;
                    }
                }
            }
            textBoxTitle.Text = comic.title;
            textBoxDate.Text = comic.date;
            textBoxAuthor.Text = comic.author;
            textBoxArtist.Text = comic.artist;
            textBoxPublisher.Text = comic.publisher;
            textBoxGenre.Text = comic.genre;
            textBoxSummary.Text = comic.summary;
            pictureBox1.Refresh();
            DrawRectangles(currentPage);
        }

        private void convertPDFToJPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string pdfPath = openFileDialog1.FileName;
            FileInfo fi = new FileInfo(pdfPath);
            MagickReadSettings settings = new MagickReadSettings();
            // Settings the density to 300 dpi will create an image with a better quality
            settings.Density = new Density(300, 300);
            using (MagickImageCollection images = new MagickImageCollection())
            {
                images.Read(fi.FullName, settings);
                
                int page = 0;
                foreach(MagickImage image in images)
                {
                    image.Format = MagickFormat.Jpg;
                    //still need naming conventiontry
                    try
                    {
                        string strPage = page.ToString();
                        image.Write(Path.Combine(fi.DirectoryName, Path.GetFileNameWithoutExtension(fi.FullName) + "_" + strPage.PadLeft(3, '0') + ".jpg"));
                    }
                    catch (Exception ex)
                    {
                    }
                    page++;
                }
            }
            MessageBox.Show("Conversion from PDF complete");
        }
    }
    public class Comic
    {
        public string title { get; set; }
        public string date { get; set; }
        public string summary { get; set; }
        public string author { get; set; }
        public string artist { get; set; }
        public string publisher { get; set; }
        public string genre { get; set; }
        public string cover = "comic000";
        public List<Page> pages { get; set; }

        public Comic()
        {
            pages = new List<Page>();
        }
    }
    public class Page
    {
        public int page_number { get; set; }
        public string file_name { get; set; }
        public List<Panel> panels { get; set; }

        public Page()
        {
            panels = new List<Panel>();
        }
    }
    public class Panel
    {
        public int page_number { get; set; }
        public int panel_number { get; set; }
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
    }
}
