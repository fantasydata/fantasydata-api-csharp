using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="News")]
    [Serializable]
    public partial class News
    {
        [DataMember(Name = "NewsID", Order = 1)]
        public int NewsID { get; set; }

        [DataMember(Name = "PlayerID", Order = 2)]
        public int? PlayerID { get; set; }

        [DataMember(Name = "Title", Order = 3)]
        public string Title { get; set; }

        [DataMember(Name = "Content", Order = 4)]
        public string Content { get; set; }

        [DataMember(Name = "Url", Order = 5)]
        public string Url { get; set; }

        [DataMember(Name = "Source", Order = 6)]
        public string Source { get; set; }

        [DataMember(Name = "TermsOfUse", Order = 7)]
        public string TermsOfUse { get; set; }

        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

    }
}

