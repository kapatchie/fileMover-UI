using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace fileMover
{
    public partial class Form1 : Form
    {
        List<Repository> fileRepositories = new List<Repository>();
        public Form1()
        {
            InitializeComponent();
            fileRepositories.AddRange(FileManager.loadData());
            txtBoxStartLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            foreach (var repository in fileRepositories)
            {
                switch (repository.Type)
                {
                    case 1:
                        textBoxAudio.Text = repository.Destination;
                        chkBoxAudio.Checked = true;
                        break;
                    case 2:
                        textBoxVideo.Text = repository.Destination;
                        chkBoxVideo.Checked = true;
                        break;
                    case 3:
                        textBoxCompressed.Text = repository.Destination;
                        chkBoxCompressed.Checked = true;
                        break;
                    case 4:
                        textBoxExecutable.Text = repository.Destination;
                        chkBoxExecutable.Checked = true;
                        break;
                    case 5:
                        textBoxImage.Text = repository.Destination;
                        chkBoxImage.Checked = true;
                        break;
                }
            }
            fileRepositories.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Files Moved", -2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (chkBoxAudio.Checked)
            {
                fileRepositories.Add(new Repository(textBoxAudio.Text, 1));
            }
            if (chkBoxVideo.Checked)
            {
                fileRepositories.Add(new Repository(textBoxVideo.Text, 2));
            }
            if (chkBoxCompressed.Checked)
            {
                fileRepositories.Add(new Repository(textBoxCompressed.Text, 3));
            }
            if (chkBoxCompressed.Checked)
            {
                fileRepositories.Add(new Repository(textBoxExecutable.Text, 4));
            }
            if (chkBoxImage.Checked)
            {
                fileRepositories.Add(new Repository(textBoxImage.Text, 5));
            }
            FileManager.wordsToDelete.Add("y2mate -");
            FileManager.MoveFiles(fileRepositories, chkBoxLocation.Checked, txtBoxStartLocation.Text);
            UpdateUI();
            FileManager.saveData(fileRepositories);
        }

        public void UpdateUI()
        {
            List<string> OutputData = new List<string>();
            if (UIController.Instance.text != null)
            {
                OutputData.AddRange(UIController.Instance.text.Split('*'));
                UIController.Instance.text = "";
                foreach (var output in OutputData)
                {
                    listView1.Items.Add(output);
                }
            }
        }

        private void btnAudioBrowse_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            textBoxAudio.Text = fd.SelectedPath;
        }

        private void btnVideoBrowse_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            textBoxVideo.Text = fd.SelectedPath;
        }

        private void btnExecutableBrowse_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            textBoxExecutable.Text = fd.SelectedPath;
        }

        private void btnCompressedBrowse_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            textBoxCompressed.Text = fd.SelectedPath;
        }

        private void btnImageBrowse_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            textBoxImage.Text = fd.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string message =
                 "This application Take files from your downloads folder and moves them to the desktop" +
                 "it will then put each file into the folder specified above, it moves files based on extension so" +
                 "All mp3 will go to the audio location etc," + @"Bug? Pease report on github:\n\r" +
                 "https://github.com/kapatchie/fileMover-UI/issues;";
            MessageBox.Show(message);
        }

        private void btnStartBrowse_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            txtBoxStartLocation.Text = fd.SelectedPath;
        }
    }
}
