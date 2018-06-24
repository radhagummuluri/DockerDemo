using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerDemo.Web.Models
{
    public class HomeModel
    {
        public string MyId { get; set; }
        public string MessageFromApi { get; set; }
        public bool IsContainer { get; set; }
    }
}
