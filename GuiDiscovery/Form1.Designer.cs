﻿using System.Windows.Forms;

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
            comboBox_layers = new ComboBox();
            button_export = new Button();
            textBox_Name = new TextBox();
            comboBox_file = new ComboBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            listBox_url.Location = new Point(426, 121);
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
            button_wl.Location = new Point(285, 176);
            button_wl.Name = "button_wl";
            button_wl.Size = new Size(75, 23);
            button_wl.TabIndex = 3;
            button_wl.Text = "Word List";
            button_wl.UseVisualStyleBackColor = true;
            button_wl.Click += button_wl_Click;
            // 
            // button_crawl
            // 
            button_crawl.Location = new Point(164, 176);
            button_crawl.Name = "button_crawl";
            button_crawl.Size = new Size(75, 23);
            button_crawl.TabIndex = 4;
            button_crawl.Text = "Crawl";
            button_crawl.UseVisualStyleBackColor = true;
            button_crawl.Click += button_crawl_Click;
            // 
            // comboBox_layers
            // 
            comboBox_layers.FormatString = "N0";
            comboBox_layers.FormattingEnabled = true;
            comboBox_layers.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox_layers.Location = new Point(274, 121);
            comboBox_layers.Name = "comboBox_layers";
            comboBox_layers.Size = new Size(121, 23);
            comboBox_layers.TabIndex = 5;
            // 
            // button_export
            // 
            button_export.Location = new Point(320, 258);
            button_export.Name = "button_export";
            button_export.Size = new Size(91, 26);
            button_export.TabIndex = 6;
            button_export.Text = "Export";
            button_export.UseVisualStyleBackColor = true;
            button_export.Click += button_export_Click;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(31, 261);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(156, 23);
            textBox_Name.TabIndex = 7;
            // 
            // comboBox_file
            // 
            comboBox_file.FormattingEnabled = true;
            comboBox_file.Items.AddRange(new object[] { "Text", "CSV" });
            comboBox_file.Location = new Point(193, 261);
            comboBox_file.Name = "comboBox_file";
            comboBox_file.Size = new Size(121, 23);
            comboBox_file.TabIndex = 8;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(31, 363);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(364, 23);
            progressBar1.TabIndex = 9;
            progressBar1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 95);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 10;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 95);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 11;
            label2.Text = "Layers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 216);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 12;
            label3.Text = "Export";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 243);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 13;
            label4.Text = "File Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 243);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 14;
            label5.Text = "File Type";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(comboBox_file);
            Controls.Add(textBox_Name);
            Controls.Add(button_export);
            Controls.Add(comboBox_layers);
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
        private ComboBox comboBox_layers;
        private Button button_export;
        private TextBox textBox_Name;
        private ComboBox comboBox_file;
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}