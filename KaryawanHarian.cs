using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasIPAC
{
  public class KaryawanHarian : Karyawan
  {
    public int jmljamkerja {get;set;}
    public int upahperjam {get;set;}
    public override double gaji()
    {
      return jmljamkerja*upahperjam;
    }
  }
}
