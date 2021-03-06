﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        public string TournamentName { get; set; }

        public decimal EntryFee { get; set; }

        public List<GameModel> WhichGame { get; set; } = new List<GameModel>();

        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        public List<List<MatchupModel>> Round { get; set; } = new List<List<MatchupModel>>();
    }
}
