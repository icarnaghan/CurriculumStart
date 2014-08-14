﻿using System.ComponentModel.DataAnnotations;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.UI.Models
{
    public class ScienceBigIdeaViewModel
    {
        public int Id { get; set; }
        public int BigIdeaForScienceId { get; set; }
        public string Context { get; set; }
        public int SectionId { get; set; }

        [UIHint("ScienceBigIdeaDropDownList")]
        public ScienceBigIdeaListViewModel ScienceBigIdeaList { get; set; }

    }
}