﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApi.Models.Data
{
    public class UserAdmin
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
