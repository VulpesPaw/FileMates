using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace FileMates
{
    // todo get dir not more
    //var filesDestination = Directory.GetFiles(global.destination, "*.*", SearchOption.AllDirectories);
    // ? Array filesOrigPath = Directory.GetFiles(global.original, "*.*", SearchOption.AllDirectories);
    // ? Array filesSearchPath = Directory.GetFiles(global.search, "*.*", SearchOption.AllDirectories);
    // Todo: compare file names, then use the common list index to and move files
    // TODO: on move, option to make dirs based on extentions
    // Todo: dupplicate protection -- just add extention like file_0.jpg, file_1.jpg ...
    // Todo: When finished, put on an apropriate linscense, like 'Unlincenced'

    // ? Reference project; TutorialHaven  - ConsoleUI
    public partial class Form1 : Form
    {
        private enum e_exportMode
        {
            move = 0,
            copy = 1
        }

        private e_exportMode exportMode = e_exportMode.move;
        private Globals global = new Globals();

        public Form1()
        {
            // Fix self-ish updateing
            // https://www.youtube.com/watch?v=9mUuJIKq40M
            // Select mutliple files with File Dialog: https://stackoverflow.com/a/12909759
            InitializeComponent();

            /* ! DEVELOPMENT SHORTCUTS
             * ------ */

            exportMode = e_exportMode.move;

            //! Easier selection of directoies

            global.originalPath = @"D:\Temp\Demos\Filesystem\SubFolderA";
            global.searchPath = @"D:\Temp\Demos\Filesystem\SubFolderB";
            global.destinationPath = @"D:\Temp\Demos\Filesystem\SubFolderC\C";

            /* ! GET CONSOLE OUTPUT WINDOW
             *
             * https://stackoverflow.com/questions/4362111/how-do-i-show-a-console-output-window-in-a-forms-application
             */
        }

        private void exportFiles()
        {
            // todo Development shortcuts, start with only folder searches, implements certain files lates
        }

        private void FldFindOriginalBtn_Click(object sender, EventArgs e)
        {
            // todo create lists for file locations

            DialogResult r = originalFolderDlg.ShowDialog();
            // global.original = originalFolderDlg.SelectedPath;
            //! Develop shortcut
            global.originalPath = @"D:\Temp\Demos\Filesystem\SubFolderA";
            lblogFldPath.Text = originalFolderDlg.SelectedPath;
        }

        private void FldFindSearchBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = searchFolderDlg.ShowDialog();
            //global.search = searchFolderDlg.SelectedPath;
            //! Develop shortcut
            global.searchPath = @"D:\Temp\Demos\Filesystem\SubFolderB";
            lblsrchFldPath.Text = searchFolderDlg.SelectedPath;
        }

        private void FldFindDestinationBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = destinationFolderDlg.ShowDialog();
            //global.destination = destinationFolderDlg.SelectedPath;
            //! Develop shortcut
            global.destinationPath = @"D:\Temp\Demos\Filesystem\SubFolderC\C";
            lbldsFldPath.Text = destinationFolderDlg.SelectedPath;
        }

        /*
         foreach(var item in myDictionary)
            {
            foo(item.Key);
            bar(item.Value);
            }
        */

        private void btnRun_Click(object sender, EventArgs e)
        {
            doFunctionOfEverything();
        }

        // ? Will move files
        private void btnMoveFiles_Click(object sender, EventArgs e)
        {
            try
            {
                //! STORE FILE OBJECTS, THUS WHEN MOVING. I CAN TAKE THE FILEWITHEXCTENTION, AND SO ON!
                // todo Searchoptions should be optional, and changible!

                // todo make addFilesToDictionary into a recursive loop, migth wanna multiple libaries.
                // todo should thereafter move into a seperate function
                // adds filepaths of original directory and searchpaths into a dictionary
                addFilesToDictionary(path: global.originalPath, searchOption: SearchOption.TopDirectoryOnly);
                addFilesToDictionary(path: global.searchPath, searchOption: SearchOption.TopDirectoryOnly);

                // move files into destination folder

                /* TODO § ---------- §
                 * check if directroy exsists; create new dir
                 * move files to dir
                 * if multiple files with same name, add _1, _2 etc. to them
                 */
                bool directoryExists = createDirectory(global.destinationPath);
                if(directoryExists)
                {
                    moveFiles();
                }
            } catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private bool createDirectory(string @path)
        {
            Console.WriteLine($"\tDirectory Exists \n\r\n\rPath: {path}\n\r");
            bool pathExists = Directory.Exists(path);
            Console.WriteLine($"Does path exists: \t {pathExists} \t {path}");

            //? Directory Exist, and creating them
            if(pathExists)
            {
                Console.WriteLine("Dir Exists");
            } else
            {
                Console.WriteLine("Dir does not exist");

                // todo Add destination path
                DialogResult res = MessageBox.Show(
                    "Destination folder does not exsist, do you want to create a new folder at destination?"
                    , "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(res != DialogResult.Yes)
                {
                    Console.WriteLine("-- CANCEL OPERATION --");

                    // directory Unsucsessfull
                    return false;
                }
                Directory.CreateDirectory(path);
            }
            return true;
        }

        private void moveFiles()
        {
            try
            {
                foreach(KeyValuePair<string, List<FilePath>> kvp in global.fileDictionary)
                {
                    // key - filename : string
                    Console.WriteLine(kvp.Key);

                    // value - filepaths : list<FilePath>
                    //* kvp.Value.ForEach(Console.WriteLine);
                    //kvp.Value = list of filepaths
                    // ? Moves files - continue here

                    foreach(FilePath filePath in kvp.Value)
                    {

                        if(kvp.Value.Count >= 2)
                        File.Move(filePath.FullFilePath, $@"{global.destinationPath}\{filePath.FilenameWithExtention}");
                    }
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Adds a directory of files to global.fileDictionary.
        /// Filename without extention is the key, and value[0] are the full path to the file, while value[1] are the filename with extention
        /// </summary>
        /// <param name="path">Path to the directory to be searched and added</param>
        /// <param name="filter">A whitelist for types of files to be added, default = all files</param>
        /// <param name="searchOption">Defines what death should be searched, default = all directories</param>
        private void addFilesToDictionary(string path, string filter = "*.*", SearchOption searchOption = SearchOption.AllDirectories)
        {
            //try
            //{
            Console.WriteLine($"===== START OF '{path}' ===== \n\r");
            // Adds files and file paths to a dictionary
            foreach(string file in Directory.GetFiles(path, filter, searchOption))
            {
               try
                {
                    Console.WriteLine($"\t\t File --> {file} ");
                    // Adds file path properties to filePath
                    // Adds path to dictionary
                    FilePath filePath = new FilePath(Path.GetFullPath(file), Path.GetFileName(file));


                    // List.Add(file objs)
                    global.fileDictionary[Path.GetFileNameWithoutExtension(file)].Add(filePath);
                    Console.WriteLine($" \n\r \t{Path.GetFileName(file)}\n\r \t{Path.GetFullPath(file)}\n\r");
                    Console.WriteLine("-- 1");
                } catch(KeyNotFoundException)
                {
                    // If Dictionary key not found, add key
                    FilePath filePath = new FilePath(Path.GetFullPath(file), Path.GetFileName(file));

                    // If key does not exist (ie. exception thrown), add key
                    global.fileDictionary[Path.GetFileNameWithoutExtension(file)] = new List<FilePath>();
                    global.fileDictionary[Path.GetFileNameWithoutExtension(file)].Add(filePath);

                    Console.WriteLine($" \n\r \t{Path.GetFileName(file)}\n\r \t{Path.GetFullPath(file)}\n\r");

                    Console.WriteLine("-- 0");
                } catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                
                //List<string> filePaths = new List<string>();
                //global.fileDictionary[Path.GetFileNameWithoutExtension(file)] = filePaths;
                //filePaths.Add(file);
            }
            Console.WriteLine("\n\r===== END OF {0} ====\n\r", path);

            /* Console -----
             * 
             * 
             *    File: B (3)
             *
             *            Filenames:        // emptey
             *            Filepaths:        // emptey
             *   FileMates.FilePath
             *
             *
             */
            /* } catch(Exception)
             {
                 throw;
             }*/
            foreach(KeyValuePair<string, List<FilePath>> kvp in global.fileDictionary)
            {
                Console.WriteLine($"\n\r \n\r File: {kvp.Key}");

                // _path in List<FilePath>
                foreach(FilePath _path in kvp.Value)
                {
                    Console.WriteLine($"  \n\r \t Filenames: \t {_path.FilenameWithExtention} \n\r \t Filepaths: \t {_path.FullFilePath}");
                    Console.WriteLine(_path.ToString());
                    Console.WriteLine("\n\r");
                }
            }

        }

        /* ? ========== ENVEN COLUMNS ========= */

        //? Tog get column tabs in console
        public string EvenColumns(int desiredWidth, IEnumerable<IEnumerable<string>> lists)
        {
            return string.Join(Environment.NewLine, EvenColumns(desiredWidth, true, lists));
        }

        public IEnumerable<string> EvenColumns(int desiredWidth, bool rightOrLeft, IEnumerable<IEnumerable<string>> lists)
        {
            return lists.Select(o => EvenColumns(desiredWidth, rightOrLeft, o.ToArray()));
        }

        public string EvenColumns(int desiredWidth, bool rightOrLeftAlignment, string[] list, bool fitToItems = false)
        {
            // Right alignment needs "-X" 'width' vs left alignment which is just "X" in the `string.Format` format string
            int columnWidth = (rightOrLeftAlignment ? -1 : 1) *
                                // Fit to actual items? this could screw up "evenness" if
                                // One column is longer than the others
                                // And you use this with multiple rows
                                (fitToItems
                                    ? Math.Max(desiredWidth, list.Select(o => o.Length).Max())
                                    : desiredWidth
                                );

            // Make columns for all but the "last" (or first) one
            string format = string.Concat(Enumerable.Range(rightOrLeftAlignment ? 0 : 1, list.Length - 1).Select(i => string.Format("{{{0},{1}}}", i, columnWidth)));

            // Then add the "last" one without Alignment
            if(rightOrLeftAlignment)
            {
                format += "{" + (list.Length - 1) + "}";
            } else
            {
                format = "{0}" + format;
            }

            return string.Format(format, list);
        }

        /* ! ======== REMVOVE DEV-CODE BELLOW ========*/

        // Dev F1 function
        private void btnF1_Click(object sender, EventArgs e)
        {
            IDictionary<string, List<string>> fileDictionary = new Dictionary<string, List<string>>();

            fileDictionary["a"] = new List<string> { @"C:/temp/dev", @"C:/temp/pngs" };
            List<string> pathA = fileDictionary["a"];
            pathA.Add(@"C:/noMapper");
            fileDictionary["a"].Add(@"C:/noMapper");
            foreach(List<string> value in fileDictionary.Values)
            {
                value.ForEach(Console.WriteLine);
            }
            /*
            List<string> pathB = fileDictionary["b"];
            pathB.Add(@"C:/BPath");
            */
            try
            {
                fileDictionary["b"].Add(@"C:/BPath");
            } catch(Exception)
            {
                fileDictionary["b"] = new List<string> { @"C:/BPath" };
            }
            Console.WriteLine("============================================");
            foreach(List<string> value in fileDictionary.Values)
            {
                value.ForEach(Console.WriteLine);
            }
        }

        private void doFunctionOfEverything()
        {
            /* try
             {*/

            // public IDictionary<string, FileObject> fileDictionary = new Dictionary<string, FileObject>();

            //global.fileDictionary.Add(files)
            //! EVERY KEY (AND VALUE?) TO LOWECASE
            /*  foreach(string file in Directory.GetFiles(global.original, "*.*", SearchOption.AllDirectories))
              {
                  //global.filenamesOriginal.Add(Path.GetFileName(file));
                  List<string> filePaths = new List<string>();
                  filePaths.Add(file);

                  global.fileDictionary[Path.GetFileNameWithoutExtension(file)] = filePaths;
              }
              //  global.filenamesOriginal.ForEach(Console.WriteLine);
              try
              {
                  foreach(string file in Directory.GetFiles(global.search, "*.*", SearchOption.AllDirectories))
                  {
                      List<string> filePaths = global.fileDictionary[Path.GetFileNameWithoutExtension(file)];
                      filePaths.Add(Path.GetFullPath(file));
                  }
              } catch(Exception e)
              {
                  // do stuff
              }*/

            // ignore default values! and argument orders!
            addFilesToDictionary(path: global.originalPath, searchOption: SearchOption.TopDirectoryOnly);
            addFilesToDictionary(path: global.searchPath, searchOption: SearchOption.TopDirectoryOnly);
            // Console.WriteLine("==================================");

            //? Prining result
            /*
            foreach(List<string> value in global.fileDictionary.Values)
                {
                    value.ForEach(Console.WriteLine);
                }
                Console.WriteLine("==================================");
                foreach(var value in global.fileDictionary)
                {
                    Console.WriteLine("--"+value.Key);
                value.Value.ForEach(Console.WriteLine);
                }
                Console.WriteLine("==================================");
            */
            //? Test of exstracting a specific element --remove
            // Console.WriteLine("\n\r Extraction testing \n\r");
            //   global.fileDictionary["A (1)"].ForEach(Console.WriteLine);
            // ? Console outputs --remove
            //global.filenamesOriginal.ForEach(Console.WriteLine);
            //global.filenamesSearch.ForEach(Console.WriteLine);

            //var CommonList = global.filenamesOriginal.Intersect(Path.GetFileName(global.fullpathsSearch));

            /* TODO:
             *
             * Check if path exist (promt to create it, change destination or cancel process), this should ideally be done before files searches due to efficency
             * Move / copy files, option for sorting based on exctentions

         /*   } catch(Exception e)
            {
                throw;
            }*/
        }
    }
}