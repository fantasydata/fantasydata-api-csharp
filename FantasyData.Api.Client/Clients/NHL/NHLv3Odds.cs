using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NHL;

namespace FantasyData.Api.Client
{
    public partial class NHLv3OddsClient : BaseClient
    {
        public NHLv3OddsClient(string apiKey) : base(apiKey) { }
        public NHLv3OddsClient(Guid apiKey) : base(apiKey) { }

    }
}

