using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMates
{
    internal class Globals
    {
        //! CREATE A CONSTRUCTOR AND PROPERTIES // prop tab tab
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
        //public IDictionary<string, FilePath> fileDictionary2 = new Dictionary<string, FilePath>(); 
        
        //? Dictionary <FILENAME, LIST_OF_FILE_PATHS> ... = new Dictionary<...>
       public IDictionary<string, List<FilePath>> fileDictionary = new Dictionary<string, List<FilePath>>();
    }
}