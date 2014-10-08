using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Filesets;

//using EnvDTE;

namespace FilesetsLibrary
{
    public partial class FilesetsWindow : Form
    {

        private IFilesetsRepo filesetsRepo;

        public FilesetsWindow(IFilesetsRepo repo)
        {
            filesetsRepo = repo;
            InitializeComponent();
            listViewColumn.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewColumn.Width = listViewColumn.Width - 2;

            ListOpenDocuments();
        }

        private void ListOpenDocuments()
        {
            var docs = filesetsRepo.GetOpenDocuments();

            //ListView example at http://msdn.microsoft.com/en-us/library/system.windows.forms.listview.view%28v=VS.90%29.aspx
            listView1.Items.AddRange(
                docs.Select(doc => new ListViewItem(doc.Name) {ToolTipText = doc.FullPath, Checked = true}).ToArray());

        }

        //public FilesetsManager(FileCabinet fc, Documents docs)
        //{
        //    FileCabinet = fc;
        //    Documents = docs;
        //    InitializeComponent();
        //    BindFilesetList();
        //}

        //public FileCabinet FileCabinet { get; set; }
        //public Documents Documents { get; set; }

        //private void BindFilesetList()
        //{
        //    listBox1.DataSource = null;
        //    listBox1.DataSource = FileCabinet.Filesets;
        //    listBox1.DisplayMember = "Name";
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            string setName = textBox1.Text;
            if (string.IsNullOrWhiteSpace(setName) || filesetsRepo.GetFilesets().Any(fs => fs.Name == setName))
            {
                MessageBox.Show("Invalid name.");
                return;
            }

            var selectedItems = listView1.SelectedItems;
            //List<string> filePaths = Documents.Cast<Document>().Select(doc => doc.FullName).ToList();
            //FileCabinet.Filesets.Add(new Fileset() { Name = setName, Paths = filePaths });
            //Documents.CloseAll();
            //BindFilesetList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var selectedFileset = (Fileset)listBox1.SelectedItem;
            //selectedFileset.Paths.ForEach(path => Documents.Open(path));
        }
    }
}
