using Boilerplate.Domain.Core.Entities;
using System.Collections.Generic;

namespace Boilerplate.Domain.Entities
{
    public class ObservationType : Entity
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }

        public List<Observation> Observations { get; set; }
        //public virtual ICollection<Observation> Observations { get; set; }
        //public ObservationType()
        //{
        //    Observations = new HashSet<Observation>();
        //}
    }
}