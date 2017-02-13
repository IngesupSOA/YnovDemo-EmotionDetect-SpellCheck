using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDevice.Models
{
    public class APIModels
    {
        public string _type { get; set; }

        public IEnumerable<FlaggedToken> flaggedTokens { get; set; }
    }

    public class FlaggedToken
    {
        public string offset { get; set; }
        public string token { get; set; }
        public string type { get; set; }
        public string UnknownToken { get; set; }

        public IEnumerable<Suggestion> suggestions { get; set; }
    }

    public class Suggestion
    {
        public string suggestion { get; set; }
        public string score { get; set; }
    }
}