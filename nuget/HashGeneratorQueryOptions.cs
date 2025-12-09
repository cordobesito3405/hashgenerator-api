using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIVerve.API.HashGenerator
{
    /// <summary>
    /// Query options for the Hash Generator API
    /// </summary>
    public class HashGeneratorQueryOptions
    {
        /// <summary>
        /// Text to hash
        /// Example: Hello World
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Comma-separated list of algorithms or 'all' (md5, sha1, sha256, sha384, sha512, blake2b512, blake2s256)
        /// Example: sha256,md5
        /// </summary>
        [JsonProperty("algorithms")]
        public string Algorithms { get; set; }
    }
}
