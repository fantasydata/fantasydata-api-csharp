using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NBA;

namespace FantasyData.Api.Client
{
    public partial class NBAv3HeadshotsClient : BaseClient
    {
        public NBAv3HeadshotsClient(string apiKey) : base(apiKey) { }
        public NBAv3HeadshotsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Headshots Asynchronous
        /// </summary>
        public Task<List<Headshot>> GetHeadshotsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Headshot>>(() =>
                base.Get<List<Headshot>>("/v3/nba/headshots/{format}/Headshots", parameters)
            );
        }

        /// <summary>
        /// Get Headshots
        /// </summary>
        public List<Headshot> GetHeadshots()
        {
            return this.GetHeadshotsAsync().Result;
        }

    }
}

