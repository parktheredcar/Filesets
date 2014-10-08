using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilesetsLibrary
{
    public interface IFilesetsRepo
    {
        List<FilesetDocument> GetOpenDocuments();
        List<Fileset> GetFilesets();
        void AddDocumentById(string id);
    }

    public class FilesetDocument
    {
        public string Name { get; set; }
        public string FullPath { get; set; }

    }

    public class Fileset
    {
        public string Name { get; set; }
        public List<FilesetDocument> FilesetDocuments { get; set; } 
    }
}
