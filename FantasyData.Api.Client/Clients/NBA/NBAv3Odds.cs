using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NBA;

namespace FantasyData.Api.Client
{
    public partial class NBAv3OddsClient : BaseClient
    {
        public NBAv3OddsClient(string apiKey) : base(apiKey) { }
        public NBAv3OddsClient(Guid apiKey) : base(apiKey) { }

    }
}

