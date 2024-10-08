﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationID { get; set; }
        public string? City { get; set; }
        public string? DayNight { get; set; }
        public double Price  { get; set; }
        public string? Image  { get; set; }
        public string? Description  { get; set; }
        public bool Status  { get; set; }
        public int Capacity  { get; set; }
    }
}
