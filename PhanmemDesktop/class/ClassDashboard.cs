using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PhanmemDesktop
{
    internal class ClassDashboard
    {

        databaseConettion db;

        private int stt;
        private string account, bookie, channel, rule, s, status;
        public ClassDashboard()
        {
            db = new databaseConettion();
        }
      
        public ClassDashboard(int stt, string account, string bookie, string channel, string rule, string s, string status)
        {
            this.Stt = stt;
            this.Account = account;
            this.Bookie = bookie;
            this.Channel = channel;
            this.Rule = rule;
            this.S = s;
            this.Status = status;


        }
        public int Stt { get => stt; set => stt = value; }
        public string Account { get => account; set => account = value; }
        public string Bookie { get => bookie; set => bookie = value; }
        public string Channel { get => channel; set => channel = value; }
        public string Rule { get => rule; set => rule = value; }
        public string S { get => s; set => s = value; }
        public string Status { get => status; set => status = value; }
        public void hamttruyeniatri(int stT, string accounT, string bookiE, string channeL, string rulE, string sS, string statuS)
        {
            Stt = stT;
            Account = accounT;
            Bookie = bookiE;
            Channel = channeL;
            Rule = rulE;
            S = sS;
            Status = statuS;

        }

        //public databaseConettion LayDSDashboard()
        //{
        //    string strSQL = "SELECT * FROM Dashboard ";
        //    databaseConettion dt = db.Execute(strSQL);
        //    //Goi phuong thuc truy xuat du lieu
        //    return dt;
        //}
    }
   
}
