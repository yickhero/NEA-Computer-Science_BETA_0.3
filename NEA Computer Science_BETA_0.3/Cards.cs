using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Computer_Science_BETA_0._3
{
    internal class Cards
    {
        public int userid {  get; set; }
        public int cardid {  get; set; }   
        public int folderid { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public int score { get; set; }
        public Cards()
        {
            score = 0;
        }

        public Cards(int userid, int cardid, int folderid, string question, string answer)
        {
            this.userid = userid;
            this.cardid = cardid;
            this.folderid = folderid;
            this.question = question;
            this.answer = answer;
        }
    }
}
