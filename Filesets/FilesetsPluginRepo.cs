using System.Collections.Generic;
using System.Linq;
using EnvDTE;
using EnvDTE80;
using FilesetsLibrary;

namespace Filesets
{
    public class FilesetsPluginRepo : IFilesetsRepo
    {

        private DTE2 _applicationObject;
        private AddIn _addInInstance;

        public FilesetsPluginRepo(DTE2 application, AddIn addIn)
        {
            _applicationObject = application;
            _addInInstance = addIn;
        }

        public List<FilesetDocument> GetOpenDocuments()
        {
            
            //Name is the name shown in the file pane
            //Path is the path up until the name
            //FullPath is the path including the name
            Documents openDocuments = _applicationObject.Documents;
            List<FilesetDocument> filesetDocs =
                openDocuments.Cast<Document>().Select(
                    doc => new FilesetDocument {FullPath = doc.FullName, Name = doc.Name}).ToList();
            return filesetDocs;

            //FileCabinet.Filesets.Add(new Fileset() {Name = setName, Paths = filePaths});
            //Documents.CloseAll();            
        }

        private List<FilesetsLibrary.Fileset> filesets;
        public List<FilesetsLibrary.Fileset> GetFilesets()
        {
            return filesets ?? (filesets = new List<FilesetsLibrary.Fileset>());
        }

        public void AddDocumentById(string id)
        {
            _applicationObject.Documents.
        }
    }
}
