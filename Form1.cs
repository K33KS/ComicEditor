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

namespace ComicEditor
{
    
    public partial class Form1 : Form
    {
        public static string comicPath = "";
        string[] pages;
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
        jsondata json = new jsondata();
        page_info pageInfo = new page_info();
        public Form1()
        {
            InitializeComponent();
            TopMost=true;
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            folderBrowserDialog1.ShowDialog();
            comicPath = folderBrowserDialog1.SelectedPath;
            LoadComic(folderBrowserDialog1.SelectedPath);
        }

        public void LoadComic(string path)
        {
            List<string> lstPaths = Directory.GetFiles(path).ToList();
            List<string> lstPages = new List<string>();
            foreach (string f in lstPaths)
            {
                if (f.Contains(".jpeg"))
                {
                    lstPages.Add(f);
                }
            }
            pages = lstPages.ToArray();
            int index = 0;
            lblPageNumber.Text = "Page: " + (currentPage + 1);
            Dictionary<string, string> coordinates = new Dictionary<string, string>();
            if (pages.First().EndsWith(".json"))
            {
                index++;
            }
            Image image = Image.FromFile(pages[index]);
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height / 3;
            pictureBox1.Width = image.Width / 3;
            pictureBoxTextColor.BackColor = Color.LawnGreen;
            pictureBoxLineColor.BackColor = lineColor;
            pictureBoxToolColor.BackColor = Color.Yellow;
            currentPage = 0;
            int pageCounter = 1;
            List<page_info> liPageInfo = new List<page_info>();
            foreach (string page in pages)
            {
                if (!page.EndsWith(".json") || !page.EndsWith(".db"))
                {
                    panel_info panInfo = new panel_info();
                    page_info pageInfo = new page_info();
                    FileInfo fi = new FileInfo(pages[pageCounter - 1]);
                    panInfo.page_number = pageCounter;
                    panInfo.panel_number = 1;
                    panInfo.x1 = 0;
                    panInfo.y1 = 0;
                    panInfo.x2 = image.Width;
                    panInfo.y2 = image.Height;
                    pageInfo.file_name = fi.Name;
                    pageInfo.page_number = pageCounter;
                    List<panel_info> liPanInfo = new List<panel_info>();
                    liPanInfo.Add(panInfo);
                    pageInfo.panels = liPanInfo;
                    liPageInfo.Add(pageInfo);
                    pageCounter = pageInfo.page_number;
                    pageCounter++;
                }

            }
            json.pages = liPageInfo;
        }

        private void SelectPanel()
        {
            if (pageInfo.panels == null)
            {
                currentPanel = 1;
            }
            else
            {
                currentPanel = pageInfo.panels.Count;
            }
            currentPanel++;
            pageInfo = json.pages[currentPage];
            panel_info pInfo = new panel_info();
            pInfo.page_number = currentPage + 1;
            pInfo.panel_number = currentPanel;
            pInfo.x1 = cropX;
            pInfo.y1 = cropY;
            pInfo.x2 = cropX2;
            pInfo.y2 = cropY2;
            pageInfo.panels.Add(pInfo);
            json.pages[currentPage] = pageInfo;
            pictureBox1.Refresh();
            DrawRectangles(currentPage);
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
            if ((currentPage + 1) < pages.Length)
            {
                //commit panel edits for the page to the json object
                json.pages[currentPage] = pageInfo;
                currentPage++;
                Image image = Image.FromFile(pages[currentPage]);
                pictureBox1.Image = image;
                currentPagePath = pages[currentPage];
                lblPageNumber.Text = "Page: " + (currentPage + 1);
                pageInfo = json.pages[currentPage];
                if (pageInfo.panels == null)
                {
                    currentPanel = 1;
                }
                else
                {
                    currentPanel = pageInfo.panels.Count;
                }
            }
            pictureBox1.Refresh();
            DrawRectangles(currentPage);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if ((currentPage +1) != 1)
            {
                //commits the changes to the json object before changing pages and reloading the pageinfo
                json.pages[currentPage] = pageInfo;
                currentPage--;
                Image image = Image.FromFile(pages[currentPage]);
                pictureBox1.Image = image;
                currentPagePath = pages[currentPage];
                lblPageNumber.Text = "Page: " + (currentPage + 1);
                pageInfo = json.pages[currentPage];
                if (pageInfo.panels == null)
                {
                    currentPanel = 1;
                }
                else
                {
                    currentPanel = pageInfo.panels.Count + 1;
                }
            }
            pictureBox1.Refresh();
            DrawRectangles(currentPage + 1);
        }
        public void DrawRectangles(int pageIndex)
        {
            Font myFont = new Font("Arial", 22);
            List<RectangleF> rects = new List<RectangleF>();
            RectangleF rect = new Rectangle();
            page_info page = json.pages[pageIndex];
            List<panel_info> panels = page.panels;
            List<string> labelPositions = new List<string>();
            foreach (panel_info panel in panels)
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
            page_info page = json.pages[pageNum];
            List<panel_info> panels = page.panels;
            foreach (panel_info panel in panels.ToList())
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
            page_info page = json.pages[pageNum];
            List<panel_info> panels = page.panels;
            int panelCount = panels.Count;
            foreach (panel_info panel in panels.ToList())
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
            foreach (page_info page in json.pages)
            {
                foreach(panel_info panel in page.panels)
                {
                    if (panel.panel_number != 1)
                    {
                        panel.x1 = panel.x1 * 3;
                        panel.y1 = panel.y1 * 3;
                        panel.x2 = panel.x2 * 3;
                        panel.y2 = panel.y2 * 3;
                    }
                }
            }
            string jsonPath = Path.Combine(comicPath, "comic.json");
            FileInfo fi = new FileInfo(jsonPath);
            if (fi.Exists)
            {
                fi.Delete();
            }
            //JsonSerializer serializer = new JsonSerializer();
            //serializer.Serialize(file, json);
            string sanitized = JsonConvert.SerializeObject(json, Formatting.Indented);
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

        private void editComicMetadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JasonForm jform = new JasonForm();
            jform.Show();
        }
    }
    public class JasonForm : JsonEditorForm
    {
        public void JsonEditorForm()
        {
            
        }
    }
    public class jsondata
    {
        public string title { get; set; }
        public string date { get; set; }
        public string summary { get; set; }
        public string author { get; set; }
        public string artist { get; set; }
        public string publisher { get; set; }
        public string genre { get; set; }
        public List<page_info> pages { get; set; }
    }
    public class page_info
    {
        public int page_number { get; set; }
        public string file_name { get; set; }
        public List<panel_info> panels { get; set; }
    }
    public class panel_info
    {
        public int page_number { get; set; }
        public int panel_number { get; set; }
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
    }
}
