﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doggis.Data.Models
{
    public class Pet
    {
        public Guid ID { get; set; }
        public Guid OwnerID { get; set; }
        public Enums.Pet.Specie Specie { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public Enums.Pet.Size? Size { get; set; }
        public string Alergies { get; set; }
        public string Description { get; set; }
        public bool AllowsPhotos { get; set; }
        public bool Status { get; set; }

        public virtual Client Owner { get; set; }

        public virtual ICollection<ServiceSchedule> ServiceSchedules { get; set; }

        public Pet()
        {
            ServiceSchedules = new List<ServiceSchedule>();
        }
    }
}
