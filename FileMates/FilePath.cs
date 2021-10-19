using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileMates
{
    internal class FilePath

    {
        // full file path from root
        private string @_fullFilePath;

        // full filename including exctentions
        private string @_filenameWithExtention;

        public FilePath(string fullFilePath, string filenameWithourExtention)
        {
            this._fullFilePath = fullFilePath;
            this._filenameWithExtention = filenameWithourExtention;
        }

        public string FullFilePath { get { return _fullFilePath; } }
        public string FilenameWithExtention { get { return _filenameWithExtention; } }
    }
}