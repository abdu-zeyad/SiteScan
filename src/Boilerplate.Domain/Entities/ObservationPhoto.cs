using Boilerplate.Domain.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boilerplate.Domain.Entities
{
    public class ObservationPhoto : Entity
    {
        public string Description { get; set; }

        [ForeignKey(nameof(Observation))]
        public Guid ObservationId { get; set; }
        public Observation Observation { get; set; }

        [MaxLength(450)]
        public string ImagePath { get; set; }
    }
}