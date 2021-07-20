
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
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.ListBox MainTree;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox SecondTree;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Button ArrowLeft;
    }
}

