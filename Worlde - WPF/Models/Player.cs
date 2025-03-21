﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Worlde___WPF.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Datum { get; set; }
        public int Rounds { get; set; }

        public Player() { }
        public Player(string name)
        {
            Name = name;
            Datum = DateTime.Now;
            Rounds = 0;
        }

        public override string ToString()
        {
            return $"{Datum.ToString("dd.MM.yy HH:mm"), -12} {Name, 12} \t         {Rounds,3}";
        }

    }
}
