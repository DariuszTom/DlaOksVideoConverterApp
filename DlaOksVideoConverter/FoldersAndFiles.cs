using Ookii.Dialogs.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DlaOksVideoConverter
{
    public static class FoldersAndFiles
    {
        public static string AppPath() => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);

        public static string SolutionPath() => Environment.CurrentDirectory;

        public static string BrowseFolder(string initPath, [Optional] string title)
        {
            var dialog = new VistaFolderBrowserDialog();
            {
                dialog.Description = "Please select a folder.";
                dialog.UseDescriptionForTitle = true;
                dialog.SelectedPath = initPath;
                dialog.UseDescriptionForTitle = true;
                dialog.Description = title;
                dialog.ShowDialog();
            }// New dialog window to select folder
            return FormatPath(dialog.SelectedPath.ToString());
        }
        public static List<WebmFile> SelectFile(string initPath)
        {
            var res =new List<WebmFile>();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = initPath;
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Webm files (*.Webm)|*.Webm|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var item in openFileDialog.FileNames)
                    {
                        string justName = Path.GetFileNameWithoutExtension(item);
                        res.Add(new WebmFile(item, justName));
                    }
                }
                return res;
            }
        }

        public static string FormatPath(string path)
        {
            string slash = @"\";// check if path is ending with slash
            char c = path.Trim().ToString().Last();
            if (c.ToString() != slash) path += slash;
            return path;
        }
       
        }
    }
