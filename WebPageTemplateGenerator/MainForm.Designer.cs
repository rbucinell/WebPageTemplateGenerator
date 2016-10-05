namespace WebPageTemplateGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.watermarkTextBox1 = new WatermarkTextBox.WatermarkTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseNameAlertBox = new System.Windows.Forms.PictureBox();
            this.removePicturesButton = new System.Windows.Forms.Button();
            this.addPicturesButton = new System.Windows.Forms.Button();
            this.PageName = new WebPageTemplateGenerator.DataGridViewWatermarkColumn();
            this.MenuCategory = new WebPageTemplateGenerator.DataGridViewWatermarkColumn();
            this.PageURL = new WebPageTemplateGenerator.DataGridViewWatermarkColumn();
            this.External = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseNameAlertBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Build the Navigation";
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.SystemColors.Control;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.Maroon;
            this.generateButton.Location = new System.Drawing.Point(510, 412);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(95, 23);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "GENERATE";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(617, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rotation Pictures for Course";
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Location = new System.Drawing.Point(15, 324);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 95);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // watermarkTextBox1
            // 
            this.watermarkTextBox1.Location = new System.Drawing.Point(485, 31);
            this.watermarkTextBox1.Name = "watermarkTextBox1";
            this.watermarkTextBox1.Size = new System.Drawing.Size(95, 20);
            this.watermarkTextBox1.TabIndex = 11;
            this.watermarkTextBox1.Watermark = "MER010";
            this.watermarkTextBox1.TextChanged += new System.EventHandler(this.CourseNameChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(410, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "External Links will not generate pages!! It will only create a link in the naviga" +
    "tion menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageName,
            this.MenuCategory,
            this.PageURL,
            this.External});
            this.dataGridView1.Location = new System.Drawing.Point(15, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(590, 205);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellValueChanged);
            // 
            // CourseNameAlertBox
            // 
            this.CourseNameAlertBox.BackColor = System.Drawing.Color.Salmon;
            this.CourseNameAlertBox.Image = global::WebPageTemplateGenerator.Properties.Resources.attention_16;
            this.CourseNameAlertBox.Location = new System.Drawing.Point(585, 33);
            this.CourseNameAlertBox.Name = "CourseNameAlertBox";
            this.CourseNameAlertBox.Size = new System.Drawing.Size(16, 16);
            this.CourseNameAlertBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CourseNameAlertBox.TabIndex = 16;
            this.CourseNameAlertBox.TabStop = false;
            // 
            // removePicturesButton
            // 
            this.removePicturesButton.AutoSize = true;
            this.removePicturesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removePicturesButton.BackColor = System.Drawing.Color.Salmon;
            this.removePicturesButton.Image = global::WebPageTemplateGenerator.Properties.Resources.delete_file_32;
            this.removePicturesButton.Location = new System.Drawing.Point(421, 368);
            this.removePicturesButton.Name = "removePicturesButton";
            this.removePicturesButton.Size = new System.Drawing.Size(38, 38);
            this.removePicturesButton.TabIndex = 15;
            this.removePicturesButton.UseVisualStyleBackColor = false;
            // 
            // addPicturesButton
            // 
            this.addPicturesButton.AutoSize = true;
            this.addPicturesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addPicturesButton.BackColor = System.Drawing.Color.LightGreen;
            this.addPicturesButton.Image = global::WebPageTemplateGenerator.Properties.Resources.add_file_32;
            this.addPicturesButton.Location = new System.Drawing.Point(421, 324);
            this.addPicturesButton.Name = "addPicturesButton";
            this.addPicturesButton.Size = new System.Drawing.Size(38, 38);
            this.addPicturesButton.TabIndex = 9;
            this.addPicturesButton.UseVisualStyleBackColor = false;
            this.addPicturesButton.Click += new System.EventHandler(this.addPicturesButton_Click);
            // 
            // PageName
            // 
            this.PageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PageName.HeaderText = "Page Name";
            this.PageName.Name = "PageName";
            this.PageName.WatermarkText = "Weekly Topics";
            // 
            // MenuCategory
            // 
            this.MenuCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MenuCategory.HeaderText = "Menu Category";
            this.MenuCategory.Name = "MenuCategory";
            this.MenuCategory.WatermarkText = "Course";
            // 
            // PageURL
            // 
            this.PageURL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PageURL.HeaderText = "Page URL";
            this.PageURL.Name = "PageURL";
            this.PageURL.WatermarkText = "CourseTopics.html";
            // 
            // External
            // 
            this.External.FalseValue = "false";
            this.External.HeaderText = "External Link?";
            this.External.Name = "External";
            this.External.TrueValue = "true";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 463);
            this.Controls.Add(this.CourseNameAlertBox);
            this.Controls.Add(this.removePicturesButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.watermarkTextBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.addPicturesButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Create a course webpage tempalate";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseNameAlertBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addPicturesButton;
        private System.Windows.Forms.ListView listView1;
        private WatermarkTextBox.WatermarkTextBox watermarkTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button removePicturesButton;
        private System.Windows.Forms.PictureBox CourseNameAlertBox;
        private DataGridViewWatermarkColumn PageName;
        private DataGridViewWatermarkColumn MenuCategory;
        private DataGridViewWatermarkColumn PageURL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn External;
    }
}

