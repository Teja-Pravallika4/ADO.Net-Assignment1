
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootStrapFootBall.Models
{
    public class MstFootball
    {

        public int MatchID { get; set; }
        public string TeamName1 { get; set; }
        public string TeamName2 { get; set; }
        public string Status { get; set; }
        public string WinningTeam { get; set; }
        public Nullable<int> Points { get; set; }
    }
}