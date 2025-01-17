﻿using ProjectTracker.Entities.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Entities.Models
{
    public class Tickets : BaseEntity
    {
        public string Description { get; set; } = string.Empty;
        public int Priority { get; set; }
        public int Status { get; set; }
        public int RequestedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
