
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.ListBox LeftListBox;
        public System.Windows.Forms.ListBox RightListBox;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Button ArrowLeftButton;
        public System.Windows.Forms.Button ArrowRightButton;
    }
}

