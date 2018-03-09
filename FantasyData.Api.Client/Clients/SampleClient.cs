using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public class SampleClient : BaseClient
    {
        public SampleClient(string apiKey) : base(apiKey) { }
        public SampleClient(Guid apiKey) : base(apiKey) { }

        public IList<Team> GetTeams()
        {
            return base.Get<IList<Team>>("/v3/nfl/stats/json/teams");
        }

        /// <summary>
        /// Summary description
        /// </summary>
        /// <param name="season">season description 1</param>
        /// <param name="week">week description 2</param>
        public IList<Score> GetScoresByWeek(string season, string week)
        {
            return this.GetScoresByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Summary description
        /// </summary>
        /// <param name="season">season description 1</param>
        /// <param name="week">week description 2</param>
        public Task<IList<Score>> GetScoresByWeekAsync(string season, string week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("format", "json"));
            parameters.Add(new KeyValuePair<string, string>("season", season));
            parameters.Add(new KeyValuePair<string, string>("week", week));
            return Task.Run<IList<Score>>(() =>
                base.Get<IList<Score>>("/v3/nfl/stats/{format}/ScoresByWeek/{season}/{week}", parameters)
            );
        }


    }
}

