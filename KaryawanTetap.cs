﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP&Collection
{
    public class karyawantetap : karyawan
    {
        public double gajibulanan { get; set; }

        public override double gaji()
        {
            return gajibulanan;
        }
    }
}