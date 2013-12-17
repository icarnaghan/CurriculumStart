using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpeditionMapper.Models.ViewModels
{
    public class AssessmentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StaCollectionId { get; set; }
    }
}