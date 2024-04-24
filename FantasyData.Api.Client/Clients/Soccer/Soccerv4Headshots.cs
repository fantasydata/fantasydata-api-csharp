using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Soccer;

namespace FantasyData.Api.Client
{
    public partial class Soccerv4HeadshotsClient : BaseClient
    {
        public Soccerv4HeadshotsClient(string apiKey) : base(apiKey) { }
        public Soccerv4HeadshotsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Headshots Asynchronous
        /// </summary>
        public Task<List<Headshot>> GetHeadshotsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Headshot>>(() =>
                base.Get<List<Headshot>>("/v4/soccer/headshots/{format}/Headshots", parameters)
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

