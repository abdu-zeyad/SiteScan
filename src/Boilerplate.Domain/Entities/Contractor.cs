using Boilerplate.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boilerplate.Domain.Entities
{
    public class Contractor : Entity
    {
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }

        [ForeignKey(nameof(User))]

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
