using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Tennis;

namespace FantasyData.Api.Client
{
    public partial class Tennisv3StatsClient : BaseClient
    {
        public Tennisv3StatsClient(string apiKey) : base(apiKey) { }
        public Tennisv3StatsClient(Guid apiKey) : base(apiKey) { }

    }
}

