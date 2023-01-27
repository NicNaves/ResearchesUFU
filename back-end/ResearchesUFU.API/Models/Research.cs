﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ResearchesUFU.API.Models
{
    public class Research
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Summary { get; set; } = string.Empty;

        public string Status { get; set; } = Constants.RESEARCH_STATUS_ONGOING;

        public string PublicationDate { get; set; } = string.Empty;

        public string Thumbnail { get; set; } = string.Empty;

        public List<ResearchField> ResearchField { get; set; } = null!;

        //public List<Tag> Tags { get; set; } = new List<Tag>();

        //public List<User> Authors { get; set; } = new List<User>();

        //public ResearchStructure Structure { get; set; } = null!;

        public string LastUpdated { get; set; } = DateTime.UtcNow.ToString();
    }
}
