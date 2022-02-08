using Boilerplate.Domain.Core.Entities;
using Boilerplate.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boilerplate.Domain.Entities
{
    public class Observation : Entity
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }
        public string ProposedSolution { get; set; }
        public Status Status { get; set; }

        [ForeignKey(nameof(SubSite))]
        public Guid SubSiteId { get; set; }
        public SubSite SubSite { get; set; }
        
        [ForeignKey(nameof(ObservationType))]
        public Guid ObservationTypeId { get; set; }
        public List<ObservationPhoto> ObservationPhotos { get; set; }
        public ObservationType ObservationType { get; set; }
        //public ICollection<ObservationPhoto> ObservationPhotos { get; set; }
        //public Observation()
        //{
        //    ObservationPhotos = new HashSet<ObservationPhoto>();
        //}
    }
}





