﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.Nama = "Agel suprianto";
            mhs.Nim = "19.11.2834";
            mhs.Alamat = "Jl.pugeran 4 yogyakarta";
            mhs.Email = "Agel.s@students.amikom.ac.id";
            mhs.CetakInformasi();

            Dosen dosen = new Dosen();
            dosen.Nama = "Kamarudin";
            dosen.Nik = "190302123";
            dosen.NPWP = "11223344234";
            dosen.Alamat = "Jl.Wonosari";
            dosen.Email = "Kamarudin@amikom.ac.id";
            dosen.Nohp = "0813  12334";
            dosen.CetakInformasi();
        }
    }
}
