using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootStrapFootBall.Models;

namespace BootStrapFootBall.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<MstFootball> qry = new List<MstFootball>();
            using (FootBallEntities dc = new FootBallEntities())
            {
                qry = (from s in dc.FootBallLeagues
                       where s.Status == "Win"

                       select new MstFootball
                       {
                           MatchID = s.MatchID,
                           TeamName1 = s.TeamName1,
                           TeamName2 = s.TeamName2,
                           Status = s.Status,
                           WinningTeam = s.WinningTeam,
                           Points = s.Points,


                       }).ToList();

            }
            return View(qry);
        }
    }
}

       