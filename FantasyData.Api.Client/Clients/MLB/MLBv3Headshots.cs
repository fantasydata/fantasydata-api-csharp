using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client
{
    public partial class MLBv3HeadshotsClient : BaseClient
    {
        public MLBv3HeadshotsClient(string apiKey) : base(apiKey) { }
        public MLBv3HeadshotsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Headshots Asynchronous
        /// </summary>
        public Task<List<Headshot>> GetHeadshotsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Headshot>>(() =>
                base.Get<List<Headshot>>("/v3/mlb/headshots/{format}/Headshots", parameters)
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

