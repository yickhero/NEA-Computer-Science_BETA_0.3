using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Computer_Science_BETA_0._3
{
    internal class Folder
    {
        public int userid {  get; set; }
        public int folderid {  get; set; }
        public string foldername { get; set; }
        public string foldertype { get; set; }
        public List<string> tags { get; set; }
        public List<int> score { get; set; }

        public Folder()
        {
            score = new List<int>();
        }

        public Folder(int userid, int folderid, string foldername, string foldertype, List<string> tags)
        {
            this.userid = userid;
            this.folderid = folderid;
            this.foldername = foldername;
            this.foldertype = foldertype;
            this.tags = tags;
        }
    }

   
}
