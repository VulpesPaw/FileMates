﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMates
{
    internal class Globals: FileObject
    {
        // paths
        public string originalPath, searchPath, destinationPath;

        // not in use
        /*
        public List<string> filenamesOriginal = new List<string>();
        public List<string> filenamesSearch = new List<string>();
        public List<string> fullpathsSearch = new List<string>();
        public List<string> fileMatch = new List<string>();
        */
        // Add filename as key and all paths in list
        //? -- old
        //public IDictionary<string, FileObject> fileDictionary = new Dictionary<string, FileObject>(); 
        
        //? Dictionary <FILENAME, LIST_OF_FILE_PATHS> ... = new Dictionary<...>
        public IDictionary<string, List<string>> fileDictionary = new Dictionary<string, List<string>>();
    }
}