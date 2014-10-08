using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnvDTE;

namespace Filesets
{
    public partial class FilesetsManager : Form
    {
        public FilesetsManager(FileCabinet fc, Documents docs)
        {
            FileCabinet = fc;
            Documents = docs;
            InitializeComponent();
            BindFilesetList();
        }

        public FileCabinet FileCabinet { get; set; }
        public Documents Documents { get; set; }

        private void BindFilesetList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = FileCabinet.Filesets;
            listBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string setName = textBox1.Text;
            if (string.IsNullOrWhiteSpace(setName) || FileCabinet.Filesets.Any(fs => fs.Name == setName))
            {
                textBox1.Text = "Invalid name.";
                return;
            }

            List<string> filePaths = Documents.Cast<Document>().Select(doc => doc.FullName).ToList();
            FileCabinet.Filesets.Add(new Fileset() {Name = setName, Paths = filePaths});
            Documents.CloseAll();
            BindFilesetList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedFileset = (Fileset) listBox1.SelectedItem;
            selectedFileset.Paths.ForEach(path => Documents.Open(path));
        }
    }
}
