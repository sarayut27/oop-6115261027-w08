using System;

namespace oop_6115261027_w08
{
    class Program
    {
        static void Main(string[] args)
        {
            Singer s1 = new Singer("Yerim" , "Yeri" , "21" , "1999 March 5");
            Singer s2 = new Singer("Suyong" , "Joy" , "23" , "1996 September 3");
            Singer s3 = new Singer("Sungwan" , "Wendy" , "21" , "1994 February 21 ");
            Musiclabel m1 = new Musiclabel("SM" , "Korea" , "Seulgi" , s2);
            Console.WriteLine(m1);
        }
    }
}
