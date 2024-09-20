﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class About2
    {
        [Key]
        public int About2ID { get; set; }
        public string? Title1 { get; set; }
        public string? Title2 { get; set; }
        public string? Descrpition { get; set; }
        public string? Image { get; set; }
    }
}
