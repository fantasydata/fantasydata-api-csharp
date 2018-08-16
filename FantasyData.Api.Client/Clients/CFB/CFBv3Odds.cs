using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CFB;

namespace FantasyData.Api.Client
{
    public partial class CFBv3OddsClient : BaseClient
    {
        public CFBv3OddsClient(string apiKey) : base(apiKey) { }
        public CFBv3OddsClient(Guid apiKey) : base(apiKey) { }

    }
}

