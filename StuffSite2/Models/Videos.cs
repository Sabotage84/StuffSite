using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StuffSite2.Models
{
    public class Videos
    {
        private string name;

        public string Name { get { return name; } set => name = value; }

        public string UrlVideo { get { return urlVideo; } set => urlVideo = value; }

        private string urlVideo;

        
    }
}