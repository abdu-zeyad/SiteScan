using Boilerplate.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boilerplate.Domain.Entities
{
    public class Project : Entity
    {

        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }

        //[ForeignKey(nameof(Owner))]
        //public int OwnerId { get; set; }
        //public User Owner { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }
        public List<Site> Sites { get; set; }
        public List<User> Contractors { get; set; }
        //public ICollection<Site> Sites { get; set; }
        //public ICollection<User> Contractors { get; set; }

        //public Project()
        //{
        //    Sites = new HashSet<Site>();
        //    Contractors = new HashSet<User>();
        //}

    }
}
