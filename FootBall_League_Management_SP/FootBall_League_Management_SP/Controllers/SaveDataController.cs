using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using System.Web.UI.WebControls;

namespace FootBall_League_Management_SP.Controllers
{
    public class SaveDataController : Controller
    {
        // GET: SaveData
        public ActionResult SaveData()
        {
            ViewBag.result = "";
            ViewBag.matchid_notnull = "";
            return View();
        }
        [HttpPost]
        public ActionResult SaveData(string matchid, string TeamName1, string TeamName2, string status, string winningteam, string points)
        {

            if (matchid.IsNullOrWhiteSpace() || TeamName1.IsNullOrWhiteSpace() || TeamName2.IsNullOrWhiteSpace()
                || status.IsNullOrWhiteSpace() || points.IsNullOrWhiteSpace())
            {
                if (matchid.IsNullOrWhiteSpace())
                    ViewBag.matchid_notnull = "Match ID Should not be Null";
                if (TeamName1.IsNullOrWhiteSpace())
                    ViewBag.TeamName1_notnull = "Team 1 Name Should not be Null";
                if (TeamName2.IsNullOrWhiteSpace())
                    ViewBag.TeamName2_notnull = "Team 2 Name Should not be Null";
                if (status.IsNullOrWhiteSpace())
                    ViewBag.Status_notnull = "Status Should not be Null";
                if (points.IsNullOrWhiteSpace())
                    ViewBag.Points_notnull = "Points Should not be Null";

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(matchid.ToString(), "^[a-zA-Z ]"))
            {
                ViewBag.matchid_notnull = "Match ID Should be only Numbers";

            }


            else
            {
                string constring = "Data Source = ayeshasidVM; Initial Catalog = ayesha; Integrated Security = True";
                SqlConnection sqlcon = new SqlConnection(constring);
                String pname = "FootBallLeaguesStoredProcedure";
                sqlcon.Open();
                SqlCommand com = new SqlCommand(pname, sqlcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MatchId", Convert.ToInt16(matchid));
                com.Parameters.AddWithValue("@TeamName1", TeamName1);
                com.Parameters.AddWithValue("@TeamName2", TeamName2);
                com.Parameters.AddWithValue("@status", status);
                com.Parameters.AddWithValue("@winningteam", winningteam);
                com.Parameters.AddWithValue("@points", Convert.ToInt16(points));

                com.ExecuteNonQuery();
                sqlcon.Close();
                ViewBag.result = "Record Has Been Saved Successfully";
            }

            return View();
        }

    }
}