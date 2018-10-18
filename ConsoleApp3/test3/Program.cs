using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication6
{
    class Goods
    {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga)
        {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override String ToString()
        {
            return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가="
                    + danga + "]";
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get; set; }

        public override String ToString()
        {
            return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum
                    + "]";
        }
    }

    class CartTest
    {
        static void Main()
        {
            Hashtable g = new Hashtable();
            g.Add("1001","[볼펜]");
            g.Add("1001","볼펜");
            g.Add("1001","볼펜");
            g.Add("1001","볼펜");

        }
    }
}
//1      1001      볼펜    1000      2      2000 
//2      1002      연필      500      3      1500 
//3      1003      딸기      6000    2      12000 