﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Enums;

namespace Doggis.ViewModel
{
    public class VeterinaryViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public string NationalInsuranceNumber { get; set; }
        public string CouncilNumber { get; set; }
        public TimeSpan EntryTime { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public string Status { get; internal set; }
        public int AllowedSpeciesCount { get; set; }
        public Pet.Specie? AllowedSpecies { get; internal set; }
    }
}