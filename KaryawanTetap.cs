using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasIPAC
{
  public class KaryawanTetap : Karyawan
  {
    public double gajibulanan {get;set;}
    public override double gaji()
    {
      return gajibulanan;
    }
  }
}
