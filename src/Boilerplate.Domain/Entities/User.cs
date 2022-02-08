using System;
using System.ComponentModel.DataAnnotations;
using Boilerplate.Domain.Core.Entities;

namespace Boilerplate.Domain.Entities
{
    public class User : Entity
    {
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }

        public string UserName { get; set; }

        public string DisplayName { get; set; }

        public string ProfilePictureDataUrl { get; set; }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
    }
}

