using System;
using System.Net;
using System.Runtime.Serialization;

namespace FantasyData.Api.Model
{
    [DataContract]
    public class ApiException : Exception
    {
        
        [DataMember(Order = 1)]
        public int HttpStatusCode { get; set; }

        [DataMember(Order = 2)]
        public HttpStatusCode Code { get; set; }

        [DataMember(Order = 3)]
        public string Description { get; set; }

        [DataMember(Order = 4)]
        public string Help { get; set; }

        public bool IsServerError { get { return this.Code == System.Net.HttpStatusCode.InternalServerError; } }
        
    }
}
