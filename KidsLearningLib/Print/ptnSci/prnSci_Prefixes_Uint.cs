using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearningLib.Print.ptnSci
{
    public  class Prefixe
    {
        public string prefixeEn;
        public string prefixeTh;
        public string symbol;
        public string multi;
        public double factor;
        public Prefixe(string pt,string pe, string s, string m, double f)
        {
            prefixeEn = pe;prefixeTh = pt ;symbol = s;multi = m;factor = f;
        
        }
        public Prefixe()
        {
          

        }
    }
    public static class Prefixess
    {
        //https://th.wikipedia.org/wiki/คำอุปสรรคเอสไอ
        public static Prefixe yotta = new Prefixe("ยอตตะ-", "yotta-", " 	Y-", "10^24", 1000000000000000000000000d);
        public static Prefixe zetta = new Prefixe("เซตตะ-", "zetta-", "Z-", "10^21", 1000000000000000000000d);
        public static Prefixe exa = new Prefixe("เอกซะ-", "exa-", "E-", "10^18", 1000000000000000000d);
        public static Prefixe peta = new Prefixe("เพตะ-", "peta-", "P-", "10^15", 1000000000000000d);
        public static Prefixe tera = new Prefixe("เทระ-", "tera-", "T-", "10^12", 1000000000000d);
        public static Prefixe giga = new Prefixe("จิกะ-", "giga-", "G-", "10^9", 1000000000d);
        public static Prefixe mega = new Prefixe("เมกะ-", "mega-", "M-", "10^6", 1000000d);
        public static Prefixe kilo = new Prefixe("กิโล-", "kilo-", "k-", "10^3", 1000d);
        public static Prefixe hecto = new Prefixe("เฮกโต-", "hecto-", "h-", "10^2", 100d);
        public static Prefixe deca = new Prefixe("เดคา-", "deca-", "da-", "10^1", 10d);
        public static Prefixe deci = new Prefixe("เดซิ-", "deci-", "d-", "10^-1", 0.1d);
        public static Prefixe centi = new Prefixe("เซนติ-", "centi-", "c-", "10^-2", 0.01d);
        public static Prefixe milli = new Prefixe("มิลลิ-", "milli-", "m-", "10^-3", 0.001d);
        public static Prefixe micro = new Prefixe("ไมโคร-", "micro-", "μ-", "10^-6", 0.000001d);
        public static Prefixe nano = new Prefixe("นาโน-", "nano-", "n-", "10^-9", 0.000000001d);
        public static Prefixe pico = new Prefixe("พิโค-", "pico-", "p-", "10^-12", 0.000000000001d);
        public static Prefixe femto = new Prefixe("เฟมโต-", "femto-", "f-", "10^-15", 0.000000000000001d);
        public static Prefixe atto = new Prefixe("อัตโต-", "atto-", "a-", "10^-18", 0.000000000000000001d);
        public static Prefixe zepto = new Prefixe("เซปโต-", "zepto-", "z-", "10^-21", 0.000000000000000000001d);
        public static Prefixe yocto = new Prefixe("ยอกโต-", "yocto-", "y-", "10^-24", 0.000000000000000000000001d);


    }
    public class SciUnit
    {
        public string uintEn;
        public string symbol;
        public string quantityName;
        public string quantitySymbol;
    }
    public static class SI_Unit
    {


        /*
         ชื่อหน่วยวัด 	สัญลักษณ์หน่วยวัด 	ชื่อปริมาณ 	สัญลักษณ์ปริมาณ
    เมตร 	m 	ความยาว 	l (L ตัวเล็ก)
    กรัม 	g 	มวล 	m
    วินาที 	s 	เวลา 	t
    แอมแปร์ 	A 	กระแสไฟฟ้า 	I (i ตัวใหญ่)
    เคลวิน 	K 	อุณหภูมิอุณหพลวัติ 	T
    แคนเดลา 	cd 	ความเข้มของการส่องสว่าง 	Iv (i ตัวใหญ่ห้อยด้วยตัว v เล็ก)
    โมล 	mol 	ปริมาณของสาร 	n

         */

    }
    public  class prnSci_Prefixes_Uint : prnClass
    {


    }
}
