using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari_odev2
{
    class Node
    {
        public int no;
        public string isim;
        public double ort;
        public Node next;
        public Node(int no, string isim, double ort)
        {
            this.no = no;
            this.isim = isim;
            this.ort = ort;
            next = null;
        }
    }
}
