using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AzBina.Domain.Entities
{
    public class Town:BaseEntity
    {
        public string Name { get; set; } = null!;
        public District District { get; set; } = null!;
        public Guid DistrictId { get; set; }

    }
}
