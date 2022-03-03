using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DlaOksVideoConverter
{
    public partial class btnConvert : Form
    {
        const string secretMessage = "Kocham Cie Oks";
        private List<WebmFile> _ListOfFiles;

        public List<WebmFile> ListOfFiles { get => _ListOfFiles; set => _ListOfFiles = value; }

        public btnConvert()
        {
            InitializeComponent();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            ListOfFiles = FoldersAndFiles.SelectFile(FoldersAndFiles.SolutionPath());
            this.dataGridFiles.DataSource = ListOfFiles;

        }

        private void btnConverFiles_Click(object sender, EventArgs e)
        {
            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
            string outputPath = FoldersAndFiles.BrowseFolder(FoldersAndFiles.SolutionPath(), @"Select output Folder");
            int howManyConverted=0;
            for (var loopI = 0; loopI < ListOfFiles.Count; loopI++)
            {
                var item = ListOfFiles[loopI];
                if (item.IsCorrectFormat == true)
                {
                    ffMpeg.ConvertMedia(item.PathAndFile,
                        outputPath + item.FileName.Trim() +".mp4", "mp4");
                    item.Result = "Converted";
                    howManyConverted++;
                }
                else item.Result = "Skiped incorrect format";
            }
            this.dataGridFiles.Refresh();
            MessageBox.Show($"Converted {howManyConverted} files{Environment.NewLine}{secretMessage}");
        }
    }
}
