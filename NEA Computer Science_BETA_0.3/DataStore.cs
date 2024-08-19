using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Computer_Science_BETA_0._3
{
    public static class DataStore
    {
        public static int userid = 0;
        public static int current_folderid = 0;
        public static string username = "";
        public static string email = "";
        public static string current_foldername = "";
        public static int totalcardnum = 0;
        public static int currentcardcount = 1;
        public static int veryeasy_score = 0;
        public static int easy_score = 0;
        public static int okay_score = 0;
        public static int difficult_score = 0;
        public static int verydifficult_score = 0;
        public static Queue<string> cards = new Queue<string>();
    }
}
