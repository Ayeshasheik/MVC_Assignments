using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FootBall_League_Management.Models
{
    public class FootBallLeague
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Required(ErrorMessage = "Match Id is mandatory to fill")]

        public int MatchID { get; set; }

        [Required(ErrorMessage = "Team 1 is mandatory to fill")]

        public string TeamName1 { get; set; }

        [Required(ErrorMessage = "Team 2 is mandatory to fill")]

        public string TeamName2 { get; set; }

        [Required(ErrorMessage = "status is mandatory to fill")]

        public string status { get; set; }

        public string winningteam { get; set; }

        [Required(ErrorMessage = "Points is mandatory to fill")]

        public int points { get; set; }

    }

}