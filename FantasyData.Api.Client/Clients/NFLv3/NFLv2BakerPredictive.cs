using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public partial class NFLv2BakerPredictiveClient : BaseClient
    {
        public NFLv2BakerPredictiveClient(string apiKey) : base(apiKey) { }
        public NFLv2BakerPredictiveClient(Guid apiKey) : base(apiKey) { }

    }
}

