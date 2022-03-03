using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DlaOksVideoConverter
{
    public class WebmFile
    {
        private string _PathAndFile;
        private string _FileName;
        private string _Result;
        public WebmFile(string pathAndFile, string fileName) 
        {
            _PathAndFile = pathAndFile;
            _FileName = fileName;
        }

        public string PathAndFile { get => _PathAndFile; set => _PathAndFile = value; }
        public string FileName { get => _FileName; set => _FileName = value; }
        public string Result { get => _Result; set => _Result = value; }

        public bool IsCorrectFormat
        {
            get {
                string fileExt = System.IO.Path.GetExtension(PathAndFile);
                return fileExt.ToLower()==".webm"? true:false ; 
            }

        }

    }
}
