namespace fileMover
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkBoxAudio = new System.Windows.Forms.CheckBox();
            this.chkBoxVideo = new System.Windows.Forms.CheckBox();
            this.chkBoxExecutable = new System.Windows.Forms.CheckBox();
            this.chkBoxCompressed = new System.Windows.Forms.CheckBox();
            this.chkBoxImage = new System.Windows.Forms.CheckBox();
            this.textBoxAudio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Video = new System.Windows.Forms.Label();
            this.textBoxVideo = new System.Windows.Forms.TextBox();
            this.textBoxExecutable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCompressed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBoxLocation = new System.Windows.Forms.CheckBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAudioBrowse = new System.Windows.Forms.Button();
            this.btnVideoBrowse = new System.Windows.Forms.Button();
            this.btnExecutableBrowse = new System.Windows.Forms.Button();
            this.btnCompressedBrowse = new System.Windows.Forms.Button();
            this.btnImageBrowse = new System.Windows.Forms.Button();
            this.fd = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxStartLocation = new System.Windows.Forms.TextBox();
            this.btnStartBrowse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBoxAudio
            // 
            this.chkBoxAudio.AutoSize = true;
            this.chkBoxAudio.Location = new System.Drawing.Point(6, 24);
            this.chkBoxAudio.Name = "chkBoxAudio";
            this.chkBoxAudio.Size = new System.Drawing.Size(53, 17);
            this.chkBoxAudio.TabIndex = 1;
            this.chkBoxAudio.Text = "Audio";
            this.chkBoxAudio.UseVisualStyleBackColor = true;
            // 
            // chkBoxVideo
            // 
            this.chkBoxVideo.AutoSize = true;
            this.chkBoxVideo.Location = new System.Drawing.Point(6, 44);
            this.chkBoxVideo.Name = "chkBoxVideo";
            this.chkBoxVideo.Size = new System.Drawing.Size(53, 17);
            this.chkBoxVideo.TabIndex = 2;
            this.chkBoxVideo.Text = "Video";
            this.chkBoxVideo.UseVisualStyleBackColor = true;
            // 
            // chkBoxExecutable
            // 
            this.chkBoxExecutable.AutoSize = true;
            this.chkBoxExecutable.Location = new System.Drawing.Point(6, 67);
            this.chkBoxExecutable.Name = "chkBoxExecutable";
            this.chkBoxExecutable.Size = new System.Drawing.Size(79, 17);
            this.chkBoxExecutable.TabIndex = 3;
            this.chkBoxExecutable.Text = "Executable";
            this.chkBoxExecutable.UseVisualStyleBackColor = true;
            // 
            // chkBoxCompressed
            // 
            this.chkBoxCompressed.AutoSize = true;
            this.chkBoxCompressed.Location = new System.Drawing.Point(6, 87);
            this.chkBoxCompressed.Name = "chkBoxCompressed";
            this.chkBoxCompressed.Size = new System.Drawing.Size(84, 17);
            this.chkBoxCompressed.TabIndex = 4;
            this.chkBoxCompressed.Text = "Compressed";
            this.chkBoxCompressed.UseVisualStyleBackColor = true;
            // 
            // chkBoxImage
            // 
            this.chkBoxImage.AutoSize = true;
            this.chkBoxImage.Location = new System.Drawing.Point(6, 110);
            this.chkBoxImage.Name = "chkBoxImage";
            this.chkBoxImage.Size = new System.Drawing.Size(55, 17);
            this.chkBoxImage.TabIndex = 5;
            this.chkBoxImage.Text = "Image";
            this.chkBoxImage.UseVisualStyleBackColor = true;
            // 
            // textBoxAudio
            // 
            this.textBoxAudio.Location = new System.Drawing.Point(116, 13);
            this.textBoxAudio.Name = "textBoxAudio";
            this.textBoxAudio.Size = new System.Drawing.Size(152, 20);
            this.textBoxAudio.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Audio Location";
            // 
            // Video
            // 
            this.Video.AutoSize = true;
            this.Video.Location = new System.Drawing.Point(6, 43);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(78, 13);
            this.Video.TabIndex = 8;
            this.Video.Text = "Video Location";
            // 
            // textBoxVideo
            // 
            this.textBoxVideo.Location = new System.Drawing.Point(116, 40);
            this.textBoxVideo.Name = "textBoxVideo";
            this.textBoxVideo.Size = new System.Drawing.Size(152, 20);
            this.textBoxVideo.TabIndex = 9;
            // 
            // textBoxExecutable
            // 
            this.textBoxExecutable.Location = new System.Drawing.Point(116, 64);
            this.textBoxExecutable.Name = "textBoxExecutable";
            this.textBoxExecutable.Size = new System.Drawing.Size(152, 20);
            this.textBoxExecutable.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Executable Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Compressed Location";
            // 
            // textBoxCompressed
            // 
            this.textBoxCompressed.Location = new System.Drawing.Point(116, 88);
            this.textBoxCompressed.Name = "textBoxCompressed";
            this.textBoxCompressed.Size = new System.Drawing.Size(152, 20);
            this.textBoxCompressed.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Image Location";
            // 
            // textBoxImage
            // 
            this.textBoxImage.Location = new System.Drawing.Point(116, 117);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(152, 20);
            this.textBoxImage.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Do you want to create the location ?";
            // 
            // chkBoxLocation
            // 
            this.chkBoxLocation.AutoSize = true;
            this.chkBoxLocation.Location = new System.Drawing.Point(198, 183);
            this.chkBoxLocation.Name = "chkBoxLocation";
            this.chkBoxLocation.Size = new System.Drawing.Size(15, 14);
            this.chkBoxLocation.TabIndex = 17;
            this.chkBoxLocation.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(13, 216);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 18;
            this.btnDone.Text = "Move Files";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBoxVideo);
            this.groupBox1.Controls.Add(this.chkBoxExecutable);
            this.groupBox1.Controls.Add(this.chkBoxCompressed);
            this.groupBox1.Controls.Add(this.chkBoxImage);
            this.groupBox1.Controls.Add(this.chkBoxAudio);
            this.groupBox1.Location = new System.Drawing.Point(15, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 135);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Type";
            // 
            // btnAudioBrowse
            // 
            this.btnAudioBrowse.Location = new System.Drawing.Point(274, 13);
            this.btnAudioBrowse.Name = "btnAudioBrowse";
            this.btnAudioBrowse.Size = new System.Drawing.Size(75, 20);
            this.btnAudioBrowse.TabIndex = 22;
            this.btnAudioBrowse.Text = "Browse";
            this.btnAudioBrowse.UseVisualStyleBackColor = true;
            this.btnAudioBrowse.Click += new System.EventHandler(this.btnAudioBrowse_Click);
            // 
            // btnVideoBrowse
            // 
            this.btnVideoBrowse.Location = new System.Drawing.Point(274, 37);
            this.btnVideoBrowse.Name = "btnVideoBrowse";
            this.btnVideoBrowse.Size = new System.Drawing.Size(75, 20);
            this.btnVideoBrowse.TabIndex = 23;
            this.btnVideoBrowse.Text = "Browse";
            this.btnVideoBrowse.UseVisualStyleBackColor = true;
            this.btnVideoBrowse.Click += new System.EventHandler(this.btnVideoBrowse_Click);
            // 
            // btnExecutableBrowse
            // 
            this.btnExecutableBrowse.Location = new System.Drawing.Point(274, 61);
            this.btnExecutableBrowse.Name = "btnExecutableBrowse";
            this.btnExecutableBrowse.Size = new System.Drawing.Size(75, 20);
            this.btnExecutableBrowse.TabIndex = 24;
            this.btnExecutableBrowse.Text = "Browse";
            this.btnExecutableBrowse.UseVisualStyleBackColor = true;
            this.btnExecutableBrowse.Click += new System.EventHandler(this.btnExecutableBrowse_Click);
            // 
            // btnCompressedBrowse
            // 
            this.btnCompressedBrowse.Location = new System.Drawing.Point(274, 87);
            this.btnCompressedBrowse.Name = "btnCompressedBrowse";
            this.btnCompressedBrowse.Size = new System.Drawing.Size(75, 20);
            this.btnCompressedBrowse.TabIndex = 25;
            this.btnCompressedBrowse.Text = "Browse";
            this.btnCompressedBrowse.UseVisualStyleBackColor = true;
            this.btnCompressedBrowse.Click += new System.EventHandler(this.btnCompressedBrowse_Click);
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.Location = new System.Drawing.Point(274, 113);
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.Size = new System.Drawing.Size(75, 20);
            this.btnImageBrowse.TabIndex = 26;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.UseVisualStyleBackColor = true;
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Video);
            this.groupBox2.Controls.Add(this.btnImageBrowse);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnCompressedBrowse);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnExecutableBrowse);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnVideoBrowse);
            this.groupBox2.Controls.Add(this.textBoxAudio);
            this.groupBox2.Controls.Add(this.btnAudioBrowse);
            this.groupBox2.Controls.Add(this.textBoxVideo);
            this.groupBox2.Controls.Add(this.textBoxExecutable);
            this.groupBox2.Controls.Add(this.textBoxCompressed);
            this.groupBox2.Controls.Add(this.textBoxImage);
            this.groupBox2.Location = new System.Drawing.Point(232, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 147);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location";
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(12, 245);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(570, 214);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "From Where ";
            // 
            // txtBoxStartLocation
            // 
            this.txtBoxStartLocation.Location = new System.Drawing.Point(87, 10);
            this.txtBoxStartLocation.Name = "txtBoxStartLocation";
            this.txtBoxStartLocation.ReadOnly = true;
            this.txtBoxStartLocation.Size = new System.Drawing.Size(361, 20);
            this.txtBoxStartLocation.TabIndex = 31;
            // 
            // btnStartBrowse
            // 
            this.btnStartBrowse.Location = new System.Drawing.Point(454, 8);
            this.btnStartBrowse.Name = "btnStartBrowse";
            this.btnStartBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnStartBrowse.TabIndex = 32;
            this.btnStartBrowse.Text = "Browse";
            this.btnStartBrowse.UseVisualStyleBackColor = true;
            this.btnStartBrowse.Click += new System.EventHandler(this.btnStartBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 471);
            this.Controls.Add(this.btnStartBrowse);
            this.Controls.Add(this.txtBoxStartLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.chkBoxLocation);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "File Mover";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkBoxAudio;
        private System.Windows.Forms.CheckBox chkBoxVideo;
        private System.Windows.Forms.CheckBox chkBoxExecutable;
        private System.Windows.Forms.CheckBox chkBoxCompressed;
        private System.Windows.Forms.CheckBox chkBoxImage;
        private System.Windows.Forms.TextBox textBoxAudio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Video;
        private System.Windows.Forms.TextBox textBoxVideo;
        private System.Windows.Forms.TextBox textBoxExecutable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCompressed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBoxLocation;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAudioBrowse;
        private System.Windows.Forms.Button btnVideoBrowse;
        private System.Windows.Forms.Button btnExecutableBrowse;
        private System.Windows.Forms.Button btnCompressedBrowse;
        private System.Windows.Forms.Button btnImageBrowse;
        private System.Windows.Forms.FolderBrowserDialog fd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxStartLocation;
        private System.Windows.Forms.Button btnStartBrowse;
    }
}

