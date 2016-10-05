using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
namespace WebPageTemplateGenerator
{
    public struct PageData
    {
        public string Name
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
        public string URL
        {
            get;
            set;
        }
        public bool IsExternal
        {
            get;
            set;
        }
    }

    public partial class MainForm : Form
    {
        #region Properties

        /// <summary>
        /// List of Images selected to be used
        /// </summary>
        public List<string> SelectedImages
        {
            get;
            set;
        }

        /// <summary>
        /// List of data used to generate the XML
        /// </summary>
        public List<PageData> PagesToCreate
        {
            get;
            set;
        }

        /// <summary>
        /// Where will the Directory be saved
        /// </summary>
        public string CreationDirectory
        {
            get;
            set;
        }

        /// <summary>
        /// CreationDirectory + "\\" + CourseName + "\\";
        /// </summary>
        public string CourseDirectory
        {
            get
            {
                return CreationDirectory + "\\" + CourseName + "\\";
            }
        }

        /// <summary>
        /// Name of the Course
        /// </summary>
        public string CourseName
        {
            get;
            set;
        }
        #endregion

        #region Construction

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainForm( string loadfile )
        {
            SelectedImages = new List<string>();
            PagesToCreate = new List<PageData>();
            CreationDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            InitializeComponent();
            InitializeGUI();

            if ( !String.IsNullOrEmpty(loadfile) )
            {
                LoadData(loadfile);
            }
        }

        /// <summary>
        /// Form Construction helper, sets default values for GUI components
        /// </summary>
        private void InitializeGUI()
        {
            ToolTip addTip = new ToolTip();
            // Set up the delays for the ToolTip.
            addTip.AutoPopDelay = 5000;
            addTip.InitialDelay = 1000;
            addTip.ReshowDelay = 500;
            addTip.SetToolTip(this.addPicturesButton, "Add Pictures");

            ToolTip removeTip = new ToolTip();
            // Set up the delays for the ToolTip.
            removeTip.AutoPopDelay = 5000;
            removeTip.InitialDelay = 1000;
            removeTip.ReshowDelay = 500;
            removeTip.SetToolTip(this.removePicturesButton, "Remove Selected Pictures");

            //Set status label to default path
            toolStripStatusLabel1.Text = "Folder will be created in " + CreationDirectory;
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool DataGridValuesValidated()
        {
            foreach ( DataGridViewRow row in dataGridView1.Rows )
            {
                if ( row.IsNewRow )
                    continue;

                string pagename, category, url;
                bool isExternal;

                try
                {
                    pagename = row.Cells[PageName.Index].Value.ToString();
                    category = row.Cells[MenuCategory.Index].Value.ToString();
                    url = row.Cells[PageURL.Index].Value.ToString();
                    isExternal = (bool)( row.Cells[External.Index] as DataGridViewCheckBoxCell ).EditedFormattedValue;
                }
                catch ( NullReferenceException nre )
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void GetDataFromDataGrid()
        {
            PagesToCreate = new List<PageData>();
            foreach ( DataGridViewRow row in dataGridView1.Rows )
            {
                if ( row.IsNewRow )
                    continue;
                PageData data = new PageData()
                {
                    Name = row.Cells[PageName.Index].Value.ToString(),
                    Category = row.Cells[MenuCategory.Index].Value.ToString(),
                    URL = row.Cells[PageURL.Index].Value.ToString(),
                    IsExternal = (bool)( row.Cells[External.Index] as DataGridViewCheckBoxCell ).EditedFormattedValue
                };
                PagesToCreate.Add(data);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void GenerateNavigationDocument()
        {
            const string XML_ITEM_XPATH = "item[@name='{0}']";

            //Create XML Directory
            XmlDocument navDoc = new XmlDocument();
            navDoc.LoadXml(Properties.Resources.XMLDoc);
            XmlNode rootNode = navDoc.SelectSingleNode("navigation");          

            foreach ( PageData page in PagesToCreate )
            {
                XmlNode categoryNode = navDoc.SelectSingleNode("navigation/" + String.Format(XML_ITEM_XPATH, page.Category));
                if ( categoryNode == null )
                {
                    categoryNode = navDoc.CreateElement("item");
                    XmlAttribute nameAttr = navDoc.CreateAttribute("name");
                    nameAttr.Value = page.Category;
                    categoryNode.Attributes.Append(nameAttr);
                    rootNode.AppendChild(categoryNode);
                }

                XmlNode subitemNode = navDoc.CreateElement("subitem");
                XmlAttribute name = navDoc.CreateAttribute("name");
                name.Value = page.Name;
                subitemNode.Attributes.Append(name);
                XmlAttribute target = navDoc.CreateAttribute("target");
                target.Value = page.URL;
                subitemNode.Attributes.Append(target);

                if( page.IsExternal)
                {
                    XmlAttribute external = navDoc.CreateAttribute("external");
                    external.Value = "true";
                    subitemNode.Attributes.Append(external);
                }
                categoryNode.AppendChild(subitemNode);
            }

            //Write the xml
            string xmlSavePath = CourseDirectory + "content\\nav.xml";
            if ( File.Exists(xmlSavePath) )
                File.Delete(xmlSavePath);
            navDoc.Save(CourseDirectory + "content\\nav.xml");

            //write the corresponding xsl
            string xslSavePath = CourseDirectory + "content\\nav_transform.xsl";
            if ( File.Exists(xslSavePath) )
                File.Delete(xslSavePath);
            File.WriteAllText(xslSavePath, Properties.Resources.nav_transform);
        }

        /// <summary>
        /// Determines if user filled out the Course Name
        /// </summary>
        /// <returns>true, if a non empty value was entered</returns>
        private bool IsCourseNameEmpty()
        {
            return String.IsNullOrEmpty(CourseName);
        }

        #region Save and Load Data

        const string SAVEDATA_XML_ROOT   = "Data";
        const string SAVEDATA_XML_Pages  = "Pages";
        const string SAVEDATA_XML_Page   = "Page";
        const string SAVEDATA_XML_Images = "Images";
        const string SAVEDATA_XML_Image  = "Image";
        const string SAVEDATA_XML_Course = "Course";


        public void SaveData()
        {
            if ( IsCourseNameEmpty() )
            {
                MessageBox.Show(this, "Course Name is empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                GetDataFromDataGrid();
            }

            XmlDocument document = new XmlDocument();
            XmlNode rootNode = document.CreateElement(SAVEDATA_XML_ROOT);

            XmlNode courseNode = document.CreateElement(SAVEDATA_XML_Course);
            courseNode.InnerText = CourseName;
            rootNode.AppendChild(courseNode);

            XmlNode pagesNode = document.CreateElement(SAVEDATA_XML_Pages);
            foreach( PageData page in PagesToCreate)
            {
                XmlNode pageNode = document.CreateElement(SAVEDATA_XML_Page);
                
                XmlAttribute nameAttr = document.CreateAttribute("name");
                nameAttr.Value = page.Name;
                pageNode.Attributes.Append(nameAttr);

                XmlAttribute catAttr = document.CreateAttribute("category");
                catAttr.Value = page.Category;
                pageNode.Attributes.Append(catAttr);

                XmlAttribute urlAttr = document.CreateAttribute("url");
                urlAttr.Value = page.URL;
                pageNode.Attributes.Append(urlAttr);

                XmlAttribute externalAttr = document.CreateAttribute("external");
                externalAttr.Value = page.IsExternal.ToString();
                pageNode.Attributes.Append(externalAttr);

                pagesNode.AppendChild(pageNode);
            }
            rootNode.AppendChild(pagesNode);

            XmlNode imagesNode = document.CreateElement(SAVEDATA_XML_Images);
            foreach ( string img in SelectedImages )
            {
                XmlNode imgNode = document.CreateElement(SAVEDATA_XML_Image);
                imgNode.InnerText = img;
                imagesNode.AppendChild(imgNode);
            }
            rootNode.AppendChild(imagesNode);
            document.AppendChild(rootNode);
            document.Save(CreationDirectory + "\\"+ CourseName + ".rbbtemplate");
        }

        public void LoadData( string path )
        {
            using ( FileStream fs = File.OpenRead(path) )
            {
                XmlDocument document = new XmlDocument();
                document.Load(fs);

                watermarkTextBox1.Text = CourseName = document.SelectSingleNode(SAVEDATA_XML_ROOT + "/" + SAVEDATA_XML_Course).InnerText;

                PagesToCreate = new List<PageData>();
                dataGridView1.Rows.Clear();
                XmlNode pagesNodeList = document.SelectSingleNode(SAVEDATA_XML_ROOT + "/" + SAVEDATA_XML_Pages);
                foreach ( XmlNode pageNode in pagesNodeList.ChildNodes )
                {
                    PageData data = new PageData()
                    {
                        Name = pageNode.Attributes["name"].Value,
                        Category = pageNode.Attributes["category"].Value,
                        URL = pageNode.Attributes["url"].Value,
                        IsExternal = Boolean.Parse(pageNode.Attributes["external"].Value)
                    };
                    PagesToCreate.Add(data);

                    int index = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[index];
                    row.Cells[PageName.Index].Value = data.Name;
                    row.Cells[MenuCategory.Index].Value = data.Category;
                    row.Cells[PageURL.Index].Value = data.URL;
                    DataGridViewCheckBoxCell chk = ( row.Cells[External.Index] as DataGridViewCheckBoxCell );
                    if ( chk.Value == chk.TrueValue )
                    {
                        chk.Value = chk.FalseValue;
                    }
                    else
                    {
                        chk.Value = chk.TrueValue;
                    }
                    chk.Value = data.IsExternal;
                }

                SelectedImages = new List<string>();
                listView1.Items.Clear();
                XmlNode imagesNodeList = document.SelectSingleNode(SAVEDATA_XML_ROOT + "/" + SAVEDATA_XML_Images);
                foreach ( XmlNode imgNode in imagesNodeList.ChildNodes )
                {
                    string imgPath = imgNode.InnerText;
                    SelectedImages.Add(imgPath);
                    listView1.Items.Add(Path.GetFileName(imgPath));
                }
            }
        }

        #endregion
        
        #region Event Listeners

        /// <summary>
        /// Button Click listener for Generate Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateButton_Click( object sender, EventArgs e )
        {
            //Validate Values
            if ( IsCourseNameEmpty() )
            {
                MessageBox.Show(this, "Course Name is empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ( !DataGridValuesValidated() )
            {
                MessageBox.Show("Fill out all of the data!");
                return;
            }

            //Create root directory
            string coursePath = CourseDirectory + "{0}";

            Directory.CreateDirectory(CourseDirectory);
            Directory.CreateDirectory(String.Format(coursePath, "content"));
            Directory.CreateDirectory(String.Format(coursePath, "img\\rotation"));
            Directory.CreateDirectory(String.Format(coursePath, "jade"));

            //Create the page data
            GetDataFromDataGrid();

            //Create the html and jade pages
            foreach ( PageData page in PagesToCreate )
            {
                if ( page.IsExternal )
                    continue;

                //Write the root page content
                string htmlContent = String.Format(Properties.Resources.GeneratedHTMLTemplate, page.Category, page.Name, page.URL);
                File.WriteAllText(String.Format(coursePath, page.URL), htmlContent);

                //Write the content page
                File.WriteAllText(String.Format(coursePath, "content\\") + page.URL, String.Empty);

                //Write the jade template
                string jadePath = CourseDirectory + "jade\\" + Path.GetFileNameWithoutExtension(page.URL) + ".jade";
                string jadeContent = String.Format(Properties.Resources.JadeTemplate, page.Category, page.Name, page.URL);
                File.WriteAllText(jadePath, jadeContent);
            }

            GenerateNavigationDocument();

            File.WriteAllText(CourseDirectory + ".buildjade.bat", Properties.Resources.buildjade_bat);

            //create the rotation pictuers
            string roationPath = String.Format(coursePath, "img\\rotation\\");
            string picFile = "PIC{0}{1}.jpg";

            for ( int i = 1; i <= SelectedImages.Count; i++ )
            {
                string newPath = roationPath + String.Format(picFile, i < 10 ? "0" : "", i);
                if ( File.Exists(newPath) )
                    File.Delete(newPath);
                File.Copy(SelectedImages[i - 1], newPath);
            }

            //All goes well
            MessageBox.Show(this, "Generation Complete. Place created directory in courses directory, and don't forget to add link!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void addPicturesButton_Click( object sender, EventArgs e )
        {
            OpenFileDialog addImagesDialog = new OpenFileDialog();
            addImagesDialog.Filter = "Supported Images|*.jpg;*.png";
            addImagesDialog.Multiselect = true;

            DialogResult result = addImagesDialog.ShowDialog();
            if ( result == System.Windows.Forms.DialogResult.OK )
            {
                foreach ( string picture in addImagesDialog.FileNames )
                {
                    if ( !SelectedImages.Contains(picture) )
                    {
                        SelectedImages.Add(picture);
                        listView1.Items.Add(Path.GetFileName(picture));
                    }
                }
            }
        }

        private void CourseNameChanged( object sender, EventArgs e )
        {
            CourseName = watermarkTextBox1.Text;
            if ( IsCourseNameEmpty() )
            {
                CourseNameAlertBox.BackColor = Color.Salmon;
                CourseNameAlertBox.Image = Properties.Resources.attention_16;
            }
            else
            {
                CourseNameAlertBox.BackColor = Color.LightGreen;
                CourseNameAlertBox.Image = Properties.Resources.checkmark_16;
            }

        }

        private void SaveButton_Click( object sender, EventArgs e )
        {
            SaveData();
        }

        private void LoadButton_Click( object sender, EventArgs e )
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Multiselect = false;
            d.Filter = "RBB Web Templates|*.rbbtemplate";
            DialogResult dr = d.ShowDialog();
            if( dr == DialogResult.OK)
                LoadData( d.FileName );
        }

        private void QuitButton_Click( object sender, EventArgs e )
        {
            this.Dispose();
        }

        #endregion

        private void OnCellValueChanged( object sender, DataGridViewCellEventArgs e )
        {   
            DataGridViewCell cell  = ((DataGridView)sender).CurrentCell;

            if ( cell != null && cell.Value != null)
            {
                DataGridViewCheckBoxCell isExternCell = ( (DataGridView)sender ).CurrentRow.Cells[External.Index] as DataGridViewCheckBoxCell;

                if (isExternCell.Value != null && isExternCell.Value.ToString().Equals(isExternCell.TrueValue) )
                {
                    if( cell.ColumnIndex == PageURL.Index && !cell.Value.ToString().StartsWith("http://"))
                    {
                        cell.Value = "http://" + cell.Value;
                    }
                }
                else
                {
                    if ( cell.ColumnIndex == PageURL.Index && !cell.Value.ToString().EndsWith(".html") )
                    {
                        cell.Value += ".html";
                    }
                }
            }
        }
        
    }
}
