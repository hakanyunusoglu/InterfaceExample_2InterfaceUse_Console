using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample_2InterfaceUse_Console
{
    public interface Iaraba
    {
        string marka { get; set; }
        string model { get; set; }
        int yil { get; set; }
        string sanziman { get; set; }

        string OzellikOku();
    }
}
