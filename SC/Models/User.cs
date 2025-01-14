﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Models
{
    public class User
    {
        [Key]

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public ProfileMahasiswa ProfileMahasiswa { get; set; }

        [ForeignKey("ProfileMahasiswa")]
        public int? ProfileMahasiswaId { get; set; }


    }
}
