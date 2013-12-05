﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpeditionMapper.Models.ViewModels
{
    public class ExpeditionViewModel
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GradeLevelId { get; set; }
        public int BigIdeasId { get; set; }
    }
}