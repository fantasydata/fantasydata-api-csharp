using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CBB;

namespace FantasyData.Api.Client
{
    public partial class CBBv3OddsClient : BaseClient
    {
        public CBBv3OddsClient(string apiKey) : base(apiKey) { }
        public CBBv3OddsClient(Guid apiKey) : base(apiKey) { }

    }
}

