﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace FantasyData.Api.Client
{
    public abstract class BaseClient
    {

        /// <summary>
        /// The host name for making API calls.
        /// </summary>
        /// <value>Default value is api.fantasydata.net</value>
        public string Host { get; set; }

        /// <summary>
        /// The client license key used to make API calls.
        /// </summary>
        public string ApiKey { get; set; }
        
        /// <summary>
        /// Indicates whether API calls will be made over secure https connection.
        /// </summary>
        /// <value>Default value is true</value>
        public bool Https { get; set; }

        private string Scheme { get { return Https ? "https" : "http"; } }

        public BaseClient(string apiKey)
        {
            Host = "api.fantasydata.net";
            ApiKey = apiKey.Replace("-", "").ToLower();
            Https = true;
        }

        public BaseClient(Guid apiKey) : this(apiKey.ToString()) { }

        protected T Get<T>(string apiCall) { return Get<T>(apiCall, null); }

        protected T Get<T>(string apiCall, IList<KeyValuePair<string, string>> parameters)
        {
            using (var client = new System.Net.WebClient())
            {
                // Add api key
                client.Headers.Add("Ocp-Apim-Subscription-Key", ApiKey);

                // Construct url
                var uri = new UriBuilder(this.Scheme, this.Host);
                uri.Path = apiCall;
                var url = uri.Uri.ToString().ToLower().Trim();

                // Make sure parameters exist and add format=json
                if (parameters == null) parameters = new List<KeyValuePair<string, string>>();
                parameters.Add(new KeyValuePair<string, string>("format", "json"));

                // Add parameters
                foreach (var parameter in parameters)
                    url = url.Replace("{" + parameter.Key.ToLower() + "}", parameter.Value.ToLower().Trim());

                // Download json, deserialize it, and return it
                var json = client.DownloadString(url);
                return JsonConvert.DeserializeObject<T>(json);
                
            }

        }

    }
}
