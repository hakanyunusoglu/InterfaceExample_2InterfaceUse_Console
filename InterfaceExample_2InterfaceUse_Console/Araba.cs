using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample_2InterfaceUse_Console
{
    public class Araba : INumara, Iaraba
    {
        public string marka { get; set; }
        public string model { get; set; }
        private int _yil;
        public int yil { get { return _yil; }
            set 
            {
                if(value < 2005)
                {
                    _yil = 2005;
                }
                else
                {
                    _yil = value;
                }
            } 
        }
        public string sanziman { get; set; }
        private int _yildiz;
        public int yildiz { get { return _yildiz; } 
            set 
            { 
                if(value > 5)
                {
                    _yildiz = 5;
                }
                else
                {
                    _yildiz = value;
                }
            } 
        }

        public string OzellikOku()
        {
            return string.Concat("+++ARAÇ ÖZELLİKLERİMİZ+++\n", "**MARKA: ", marka, "\n", "**MODEL: ", model, "\n", "**ŞANZUMAN TÜRÜ: ", sanziman, "\n", "**MODEL YILI: ", yil, "\n", "**PUAN: ", yildiz, "\n");
        }
    }
}
