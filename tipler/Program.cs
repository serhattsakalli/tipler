using System;

namespace tipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("---------Implicit Conversion ------------------");

            byte a = 5;
            sbyte b=30;
            short c =10;

            int d =a+b+c;
            Console.WriteLine("D:"+d);

            long h=d;
            Console.WriteLine("h:"+h);

            float i=h;
            Console.WriteLine("i:"+i);

            string e= "Serha";
            char f='t';
            object g=e+f+(d-20);
            Console.WriteLine("g:"+g);


            //Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("---------Explicit Conversion ------------------");
            int x=4;
            byte y=(byte)x;
            Console.WriteLine("y="+y);
            int z=100;
            byte t=(byte)z;
            Console.WriteLine("t="+t);
            float w=10.3f;
            byte v=(byte)w;
            Console.WriteLine("v="+v);

            //------ ToString Methodu ---------
            Console.WriteLine("------ ToString Methodu ---------");
            int xx=6;
            string yy=xx.ToString();
            Console.WriteLine("yy:"+yy);
            string zz=12.5f.ToString();
            Console.WriteLine("zz:"+zz);

            //system convert 
            Console.WriteLine("------ system convert ---------");
            string s1="10",s2="20";
            int say1,say2;
            int toplam;
            say1=Convert.ToInt32(s1);
            say2=Convert.ToInt32(s2);
            toplam=say1+say2;
            Console.WriteLine("toplam="+toplam);

            //parse
            Console.WriteLine("------ Parse ---------");
            Parsemethod();


        }
        public static void Parsemethod()
        {
             string s3="10";
             string s4="10.25";
            int rakam1;
            double rakam2;

            rakam1=Int32.Parse(s3);
            rakam2=Double.Parse(s4);
            Console.WriteLine("rakam1 :"+rakam1);
            Console.WriteLine("rakam2 :"+rakam2);
        }
    }
}



