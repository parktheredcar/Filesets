using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FilesetsLibrary;

namespace FilesetsTesting
{
    public class FilesetsTestRepo : IFilesetsRepo
    {
        public List<FilesetDocument> GetOpenDocuments()
        {
            return new List<FilesetDocument>
                       {
                           new FilesetDocument {Name = "Something", FullPath = "c:\\files\\something.txt"},
                           new FilesetDocument {Name = "Another File", FullPath = "c:\\blahblah.zip"},
                           new FilesetDocument {Name = "Other stuff", FullPath = "c:\\things\\otherstuff.rar"},
                       };
        }

        private List<Fileset> filesets;  
        public List<Fileset> GetFilesets()
        {
            return filesets ?? (filesets = new List<Fileset>());
        }
    }
}
