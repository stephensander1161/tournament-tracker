﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";

        public static IDataConnection Connection { get; private set; } 

        public static void InitializeConnections(DatabaseType db)
        {
      
            if (db == DatabaseType.Sql)
            {

                // TODO - setup the sql connection properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;

            }

            else if (db == DatabaseType.TextFile)
            {
                //TODO - create the text connection

                TextConnector text = new TextConnector();
                Connection = text; 

            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
