using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mapper21.UI.Models
{
    public class CommonCoreViewModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string GradeLevelId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Strand { get; set; }
        public string SubCategory { get; set; }
        public string Domain { get; set; }
        public string ClusterStatement { get; set; }
    }
}