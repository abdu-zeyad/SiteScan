using Boilerplate.Domain.Core.Entities;

using Boilerplate.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boilerplate.Domain.Entities
{
    public class Site : Entity
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }
        public City City { get; set; }

        [ForeignKey(nameof(Project))]
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }

        public List<SubSite> SubSites { get; set; }

        //public ICollection<SubSite> SubSites { get; set; }

        //public Site()
        //{
        //    SubSites = new HashSet<SubSite>();
        //}
    }
}