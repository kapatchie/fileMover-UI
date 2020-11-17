﻿namespace fileMover
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check the file types that you want moved";
            // 
            // chkBoxAudio
            // 
            this.chkBoxAudio.AutoSize = true;
            this.chkBoxAudio.Location = new System.Drawing.Point(13, 30);
            this.chkBoxAudio.Name = "chkBoxAudio";
            this.chkBoxAudio.Size = new System.Drawing.Size(53, 17);
            this.chkBoxAudio.TabIndex = 1;
            this.chkBoxAudio.Text = "Audio";
            this.chkBoxAudio.UseVisualStyleBackColor = true;
            this.chkBoxAudio.CheckedChanged += new System.EventHandler(this.chkBoxAudio_CheckedChanged);
            // 
            // chkBoxVideo
            // 
            this.chkBoxVideo.AutoSize = true;
            this.chkBoxVideo.Location = new System.Drawing.Point(13, 54);
            this.chkBoxVideo.Name = "chkBoxVideo";
            this.chkBoxVideo.Size = new System.Drawing.Size(53, 17);
            this.chkBoxVideo.TabIndex = 2;
            this.chkBoxVideo.Text = "Video";
            this.chkBoxVideo.UseVisualStyleBackColor = true;
            this.chkBoxVideo.CheckedChanged += new System.EventHandler(this.chkBoxVideo_CheckedChanged);
            // 
            // chkBoxExecutable
            // 
            this.chkBoxExecutable.AutoSize = true;
            this.chkBoxExecutable.Location = new System.Drawing.Point(13, 78);
            this.chkBoxExecutable.Name = "chkBoxExecutable";
            this.chkBoxExecutable.Size = new System.Drawing.Size(79, 17);
            this.chkBoxExecutable.TabIndex = 3;
            this.chkBoxExecutable.Text = "Executable";
            this.chkBoxExecutable.UseVisualStyleBackColor = true;
            this.chkBoxExecutable.CheckedChanged += new System.EventHandler(this.chkBoxExecutable_CheckedChanged);
            // 
            // chkBoxCompressed
            // 
            this.chkBoxCompressed.AutoSize = true;
            this.chkBoxCompressed.Location = new System.Drawing.Point(13, 102);
            this.chkBoxCompressed.Name = "chkBoxCompressed";
            this.chkBoxCompressed.Size = new System.Drawing.Size(84, 17);
            this.chkBoxCompressed.TabIndex = 4;
            this.chkBoxCompressed.Text = "Compressed";
            this.chkBoxCompressed.UseVisualStyleBackColor = true;
            this.chkBoxCompressed.CheckedChanged += new System.EventHandler(this.chkBoxCompressed_CheckedChanged);
            // 
            // chkBoxImage
            // 
            this.chkBoxImage.AutoSize = true;
            this.chkBoxImage.Location = new System.Drawing.Point(13, 126);
            this.chkBoxImage.Name = "chkBoxImage";
            this.chkBoxImage.Size = new System.Drawing.Size(55, 17);
            this.chkBoxImage.TabIndex = 5;
            this.chkBoxImage.Text = "Image";
            this.chkBoxImage.UseVisualStyleBackColor = true;
            this.chkBoxImage.CheckedChanged += new System.EventHandler(this.chkBoxImage_CheckedChanged);
            // 
            // textBoxAudio
            // 
            this.textBoxAudio.Location = new System.Drawing.Point(370, 27);
            this.textBoxAudio.Name = "textBoxAudio";
            this.textBoxAudio.Size = new System.Drawing.Size(100, 20);
            this.textBoxAudio.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Audio Location";
            // 
            // Video
            // 
            this.Video.AutoSize = true;
            this.Video.Location = new System.Drawing.Point(260, 54);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(78, 13);
            this.Video.TabIndex = 8;
            this.Video.Text = "Video Location";
            // 
            // textBoxVideo
            // 
            this.textBoxVideo.Location = new System.Drawing.Point(370, 56);
            this.textBoxVideo.Name = "textBoxVideo";
            this.textBoxVideo.Size = new System.Drawing.Size(100, 20);
            this.textBoxVideo.TabIndex = 9;
            // 
            // textBoxExecutable
            // 
            this.textBoxExecutable.Location = new System.Drawing.Point(370, 82);
            this.textBoxExecutable.Name = "textBoxExecutable";
            this.textBoxExecutable.Size = new System.Drawing.Size(100, 20);
            this.textBoxExecutable.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Executable Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Compressed Location";
            // 
            // textBoxCompressed
            // 
            this.textBoxCompressed.Location = new System.Drawing.Point(370, 106);
            this.textBoxCompressed.Name = "textBoxCompressed";
            this.textBoxCompressed.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompressed.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Image Location";
            // 
            // textBoxImage
            // 
            this.textBoxImage.Location = new System.Drawing.Point(370, 130);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(100, 20);
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
            this.chkBoxLocation.Location = new System.Drawing.Point(199, 179);
            this.chkBoxLocation.Name = "chkBoxLocation";
            this.chkBoxLocation.Size = new System.Drawing.Size(15, 14);
            this.chkBoxLocation.TabIndex = 17;
            this.chkBoxLocation.UseVisualStyleBackColor = true;
            this.chkBoxLocation.CheckedChanged += new System.EventHandler(this.chkBoxLocation_CheckedChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.chkBoxLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCompressed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxExecutable);
            this.Controls.Add(this.textBoxVideo);
            this.Controls.Add(this.Video);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAudio);
            this.Controls.Add(this.chkBoxImage);
            this.Controls.Add(this.chkBoxCompressed);
            this.Controls.Add(this.chkBoxExecutable);
            this.Controls.Add(this.chkBoxVideo);
            this.Controls.Add(this.chkBoxAudio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}
