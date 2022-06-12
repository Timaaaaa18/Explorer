using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        static private string selectedItem;
        static private string currentPath;
        static public string[] pathArray = new string[1];

        public Form1()
        {
            InitializeComponent();            
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainTree = new System.Windows.Forms.ListBox();
            this.SecondTree = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.Label();
            this.ArrowLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.MainTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.SecondTree);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Size = new System.Drawing.Size(1445, 548);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 1;
            // 
            // MainTree
            // 
            this.MainTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTree.FormattingEnabled = true;
            this.MainTree.ItemHeight = 30;
            this.MainTree.Location = new System.Drawing.Point(0, 0);
            this.MainTree.Name = "MainTree";
            this.MainTree.Size = new System.Drawing.Size(192, 548);
            this.MainTree.TabIndex = 2;
            this.MainTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainTree_MouseClick);
            // 
            // SecondTree
            // 
            this.SecondTree.AllowDrop = true;
            this.SecondTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecondTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondTree.FormattingEnabled = true;
            this.SecondTree.ItemHeight = 30;
            this.SecondTree.Location = new System.Drawing.Point(1, 1);
            this.SecondTree.Name = "SecondTree";
            this.SecondTree.ScrollAlwaysVisible = true;
            this.SecondTree.Size = new System.Drawing.Size(1247, 546);
            this.SecondTree.TabIndex = 0;
            this.SecondTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SecondTree_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(27, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateButton_MouseClick);
            // 
            // Information
            // 
            this.Information.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Information.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Information.Location = new System.Drawing.Point(63, 0);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(1381, 30);
            this.Information.TabIndex = 0;
            // 
            // ArrowLeft
            // 
            this.ArrowLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrowLeft.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ArrowLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ArrowLeft.Image = ((System.Drawing.Image)(resources.GetObject("ArrowLeft.Image")));
            this.ArrowLeft.Location = new System.Drawing.Point(0, 0);
            this.ArrowLeft.Name = "ArrowLeft";
            this.ArrowLeft.Size = new System.Drawing.Size(30, 30);
            this.ArrowLeft.TabIndex = 2;
            this.ArrowLeft.UseVisualStyleBackColor = false;
            this.ArrowLeft.Click += new System.EventHandler(this.ArrowLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1445, 597);
            this.Controls.Add(this.ArrowLeft);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Information);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explorer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void MainTree_MouseClick(object sender, MouseEventArgs e)
        {
            SecondTree.Items.Clear();
            Information.Text = currentPath = Convert.ToString(MainTree.SelectedItem);
            Array.Resize(ref pathArray, 1);
            pathArray[0] = currentPath;
            AddDirectoriesAndFiles(Convert.ToString(currentPath));
                                            
        }

        private void AddDirectoriesAndFiles(string path)
        {
            if (path != "" && path != null)
            {
                foreach (var item in Scan.GetDirectories(path))
                {
                    SecondTree.Items.Add(Path.GetFileName(item));
                }

                foreach (var item in Scan.GetFiles(path, SecondTree.SelectedItem))
                {
                    SecondTree.Items.Add(Path.GetFileName(item));
                }
            }            
        }

        private void updateButton_MouseClick(object sender, MouseEventArgs e)
        {
            MainTree.Items.Clear();
            
            foreach (var item in Scan.GetDrives())
            {
                MainTree.Items.Add(item);
            }   
        }

        private void SecondTree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Information.Text = pathArray[pathArray.Length - 1] + @"\" + Convert.ToString(SecondTree.SelectedItem);
            currentPath = Information.Text;

            Array.Resize(ref pathArray, pathArray.Length + 1);
            pathArray[pathArray.Length - 1] = currentPath;
            SecondTree.Items.Clear();
            AddDirectoriesAndFiles(Convert.ToString(pathArray[pathArray.Length - 1]));
        }

        private void ArrowLeft_Click(object sender, EventArgs e)
        {
            if (pathArray.Length > 1)
            {
                Array.Resize(ref pathArray, pathArray.Length - 1);
                currentPath = pathArray[pathArray.Length - 1];
                Information.Text = currentPath;
            }            
            SecondTree.Items.Clear();
            AddDirectoriesAndFiles(currentPath);
        }
    }
}
