using Boilerplate.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boilerplate.Domain.Entities
{
    public class SubSite : Entity
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        [ForeignKey(nameof(Site))]
        public Guid SiteId { get; set; }
        public Site Site { get; set; }
        public List<Observation> Observations { get; set; }
        //public ICollection<Observation> Observations { get; set; }
        //public SubSite()
        //{
        //    Observations = new HashSet<Observation>();
        //}
    }
}