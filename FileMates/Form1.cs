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
            global.destinationPath = @"D:\Temp\Demos\Filesystem\SubFolderC";

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
            global.destinationPath = @"D:\Temp\Demos\Filesystem\SubFolderC";
            lbldsFldPath.Text = destinationFolderDlg.SelectedPath;
        }

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
                createDirectory(global.destinationPath);
                moveFiles();
            } catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void createDirectory(string @path)
        {
            Console.WriteLine($"\tDirectory Exists \n\r\n\rPath: {path}\n\r");
            bool pathExists = Directory.Exists(path);

            //? Directory Exist, and creating them
            if(pathExists)
            {
                Console.WriteLine("Dir Exists");
            } else
            {
                Console.WriteLine("Dir does not exist");
                Directory.CreateDirectory(path);
            }
        }

        private void moveFiles()
        {
            foreach(KeyValuePair<string, List<string>> kvp in global.fileDictionary)
            {
                // key - filename : string
                Console.WriteLine(kvp.Key);

                // value - filepaths : list<string>
                kvp.Value.ForEach(Console.WriteLine);

                // ? Moves files - continue here
               /* foreach(string filePath in kvp.Value)
                {
                    File.Move(filePath, $"{global.destinationPath}");
                }*/
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
                    // Adds path to dictionary
                    global.fileDictionary[Path.GetFileNameWithoutExtension(file)].Add(Path.GetFullPath(file));
                    Console.WriteLine("-- 1");
                } catch(KeyNotFoundException)
                {
                    // If key does not exist (ie. exception thrown), add key
                    global.fileDictionary[Path.GetFileNameWithoutExtension(file)] = new List<string> { Path.GetFullPath(file) };
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

            /* } catch(Exception)
             {
                 throw;
             }*/
        }

        private void extractFiles(/*move or copy?*/)
        {
        }

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
    }
}