﻿using DuzceUniTez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.ViewModels
{
    public class DataViewModel
    {
        public Fakulte Fakulte { get; set; }
        public IEnumerable<Bolum> Bolumler { get; set; }

    }
}