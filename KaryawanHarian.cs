using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab8.ClassInduk;

namespace Collection.ClassAnak
{
    public class KariawanHarian : Kariawan
    {
        public int JumlahJamKerja { get; set; }
        public int UpahPerJam { get; set; }
        public override double Gaji()
        {
            return JumlahJamKerja * UpahPerJam;
        }
    }
}
