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

            FileManager.MoveFiles(fileRepositories, chkBoxLocation.Checked);
            MessageBox.Show(UIController.Instance.text);
            FileManager.saveData(fileRepositories);
        }
    }
}
