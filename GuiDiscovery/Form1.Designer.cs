using System.Windows.Forms;

namespace GuiDiscovery
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_dir = new Button();
            textBox_url = new TextBox();
            listBox_url = new ListBox();
            openFileDialog = new OpenFileDialog();
            button_wl = new Button();
            button_crawl = new Button();
            SuspendLayout();
            // 
            // button_dir
            // 
            button_dir.Location = new Point(22, 176);
            button_dir.Name = "button_dir";
            button_dir.Size = new Size(75, 23);
            button_dir.TabIndex = 0;
            button_dir.TabStop = false;
            button_dir.Text = "Directory";
            button_dir.UseVisualStyleBackColor = true;
            button_dir.Click += button1_Click;
            // 
            // textBox_url
            // 
            textBox_url.Location = new Point(34, 121);
            textBox_url.Name = "textBox_url";
            textBox_url.Size = new Size(219, 23);
            textBox_url.TabIndex = 1;
            // 
            // listBox_url
            // 
            listBox_url.FormattingEnabled = true;
            listBox_url.ItemHeight = 15;
            listBox_url.Location = new Point(413, 107);
            listBox_url.Name = "listBox_url";
            listBox_url.Size = new Size(344, 274);
            listBox_url.TabIndex = 2;
            listBox_url.MouseDoubleClick += listBox_url_DoubleClick;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // button_wl
            // 
            button_wl.Location = new Point(184, 176);
            button_wl.Name = "button_wl";
            button_wl.Size = new Size(75, 23);
            button_wl.TabIndex = 3;
            button_wl.Text = "Word List";
            button_wl.UseVisualStyleBackColor = true;
            button_wl.Click += button_wl_Click;
            // 
            // button_crawl
            // 
            button_crawl.Location = new Point(103, 176);
            button_crawl.Name = "button_crawl";
            button_crawl.Size = new Size(75, 23);
            button_crawl.TabIndex = 4;
            button_crawl.Text = "Crawl";
            button_crawl.UseVisualStyleBackColor = true;
            button_crawl.Click += button_crawl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_crawl);
            Controls.Add(button_wl);
            Controls.Add(listBox_url);
            Controls.Add(textBox_url);
            Controls.Add(button_dir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_dir;
        private TextBox textBox_url;
        private ListBox listBox_url;
        private OpenFileDialog openFileDialog;
        private Button button_wl;
        private Button button_crawl;
    }
}