using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace fileMover
{
    public partial class Form1 : Form
    {
        bool moveAudio;
        bool moveVideo;
        bool moveExecutable;
        bool moveCompressed;
        bool moveImage;
        bool createLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkBoxAudio_CheckedChanged(object sender, EventArgs e)
        {
            moveAudio = chkBoxAudio.Checked;
        }

        private void chkBoxVideo_CheckedChanged(object sender, EventArgs e)
        {
            moveVideo = chkBoxVideo.Checked;
        }

        private void chkBoxExecutable_CheckedChanged(object sender, EventArgs e)
        {
            moveExecutable = chkBoxExecutable.Checked;
        }

        private void chkBoxCompressed_CheckedChanged(object sender, EventArgs e)
        {
            moveCompressed = chkBoxCompressed.Checked;
        }

        private void chkBoxImage_CheckedChanged(object sender, EventArgs e)
        {
            moveImage = chkBoxImage.Checked;
        }

        private void chkBoxLocation_CheckedChanged(object sender, EventArgs e)
        {
            createLocation = chkBoxLocation.Checked;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            List<Repository> fileRepositories = new List<Repository>();
            if (moveAudio)
            {
                fileRepositories.Add(new Repository(textBoxAudio.Text, 1));
            }
            if (moveVideo)
            {
                fileRepositories.Add(new Repository(textBoxVideo.Text, 2));
            }
            if (moveCompressed)
            {
                fileRepositories.Add(new Repository(textBoxCompressed.Text, 3));
            }
            if (moveExecutable)
            {
                fileRepositories.Add(new Repository(textBoxExecutable.Text, 4));
            }
            if (moveImage)
            {
                fileRepositories.Add(new Repository(textBoxImage.Text, 5));
            }

            FileManager.MoveFiles(fileRepositories, createLocation);
            FileManager.saveData(fileRepositories);
        }
    }
}
