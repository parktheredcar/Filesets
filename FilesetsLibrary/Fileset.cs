using System;
using System.Collections.Generic;

namespace Filesets
{
    public class Fileset
    {
        public String Name { get; set; }
        private List<string> paths;
        public List<String> Paths
        {
            get { return paths ?? (paths = new List<string>()); }
            set { paths = value; }
        }
    }

    public class FileCabinet
    {
        private List<Fileset> filesets;

        public List<Fileset> Filesets
        {
            get { return filesets ?? (filesets = new List<Fileset>()); }
            set { filesets = value; }
        } 
        public String Name { get; set; }
        public List<String> Tags { get; set; } 
    }
}
