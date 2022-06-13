using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        static private string currentPath;
        static private string[] pathArray = new string[1];
        static private List<string> pathList = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            Scan.Notify += OpenFile;
            UpdateDrives();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LeftListBox = new System.Windows.Forms.ListBox();
            this.RightListBox = new System.Windows.Forms.ListBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.ArrowLeftButton = new System.Windows.Forms.Button();
            this.ArrowRightButton = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.LeftListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.RightListBox);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Size = new System.Drawing.Size(1445, 548);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 1;
            // 
            // LeftListBox
            // 
            this.LeftListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeftListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftListBox.FormattingEnabled = true;
            this.LeftListBox.ItemHeight = 30;
            this.LeftListBox.Location = new System.Drawing.Point(0, 0);
            this.LeftListBox.Name = "LeftListBox";
            this.LeftListBox.Size = new System.Drawing.Size(192, 548);
            this.LeftListBox.TabIndex = 2;
            this.LeftListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LeftListBox_MouseClick);
            // 
            // RightListBox
            // 
            this.RightListBox.AllowDrop = true;
            this.RightListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RightListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightListBox.FormattingEnabled = true;
            this.RightListBox.ItemHeight = 30;
            this.RightListBox.Location = new System.Drawing.Point(1, 1);
            this.RightListBox.Name = "RightListBox";
            this.RightListBox.ScrollAlwaysVisible = true;
            this.RightListBox.Size = new System.Drawing.Size(1247, 546);
            this.RightListBox.TabIndex = 0;
            this.RightListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RightListBox_MouseDoubleClick);
            // 
            // PathLabel
            // 
            this.PathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PathLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathLabel.Location = new System.Drawing.Point(108, 0);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(1325, 30);
            this.PathLabel.TabIndex = 0;
            // 
            // ArrowLeftButton
            // 
            this.ArrowLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrowLeftButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ArrowLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ArrowLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("ArrowLeftButton.Image")));
            this.ArrowLeftButton.Location = new System.Drawing.Point(0, 0);
            this.ArrowLeftButton.Name = "ArrowLeftButton";
            this.ArrowLeftButton.Size = new System.Drawing.Size(30, 30);
            this.ArrowLeftButton.TabIndex = 2;
            this.ArrowLeftButton.UseVisualStyleBackColor = false;
            this.ArrowLeftButton.Click += new System.EventHandler(this.ArrowLeftButton_Click);
            // 
            // ArrowRightButton
            // 
            this.ArrowRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrowRightButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ArrowRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ArrowRightButton.Image = global::WinFormsApp1.Properties.Resources.arrowRight;
            this.ArrowRightButton.Location = new System.Drawing.Point(36, 0);
            this.ArrowRightButton.Name = "ArrowRightButton";
            this.ArrowRightButton.Size = new System.Drawing.Size(30, 30);
            this.ArrowRightButton.TabIndex = 3;
            this.ArrowRightButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1445, 597);
            this.Controls.Add(this.ArrowRightButton);
            this.Controls.Add(this.ArrowLeftButton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.PathLabel);
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

        private void LeftListBox_MouseClick(object sender, MouseEventArgs e)
        {
            RightListBox.Items.Clear();
            pathList.Clear();
            pathList.Add(LeftListBox.SelectedItem.ToString());
            PathLabel.Text = pathList[0];
            var b = pathList.ToString();
            AddDirectoriesAndFiles(ListToString(pathList));                                  
        }

        private void AddDirectoriesAndFiles(string path)
        {           
            string[] directories = Scan.GetDirectories(path);
            string[] files = Scan.GetFiles(path);
            RightListBox.Items.Clear();
            if (directories != null)
            {
                foreach (var item in directories) //TODO: get directories and files, null referance exeption
                {
                    RightListBox.Items.Add(Path.GetFileName(item));
                }
            }

            if (files != null)
            {
                foreach (var item in files)
                {
                    RightListBox.Items.Add(Path.GetFileName(item));
                }
            }
        }

        private void UpdateDrives() //TODO: Remove button, rename method
        {
            LeftListBox.Items.Clear();
            
            foreach (var item in Scan.GetDrives())
            {
                LeftListBox.Items.Add(item);
            }   
        }

        private void RightListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pathList.Count == 1)
            {
                pathList.Add(RightListBox.SelectedItem.ToString());
            }
            else pathList.Add(@"\" + RightListBox.SelectedItem.ToString());
            PathLabel.Text = ListToString(pathList);           
            AddDirectoriesAndFiles(ListToString(pathList));
        }

        private void ArrowLeftButton_Click(object sender, EventArgs e)
        {
            if (pathList.Count > 1)
            {
                Array.Resize(ref pathArray, pathArray.Length - 1);
                currentPath = pathArray[pathArray.Length - 1];
                PathLabel.Text = currentPath;
            }            
            RightListBox.Items.Clear();
            AddDirectoriesAndFiles(currentPath);
        }

        private string ListToString(List<string> list)
        {
            string finalString = string.Empty;
            foreach (var item in list)
            {
                finalString += item;
            }
            return finalString;
        }
        public void OpenFile(string path)
        {
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = path;
            proc.StartInfo.UseShellExecute = true;
            proc.Start(); //TODO: can`t open .dll 
        }       
    }
}
