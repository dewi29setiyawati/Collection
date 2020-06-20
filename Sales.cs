using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasIPAC
{
  public class Sales : Karyawan
  {
    public int jmljualan {get;set;}
    public int komisi {get;set;}
    public override double gaji()
    {
      return jmljualan*komisi;
    }
  }
}
