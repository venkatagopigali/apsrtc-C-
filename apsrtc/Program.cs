namespace Gali
{
    class Gopi
    {
        static void Main(String[] args)
        {
            String n,t,s,d;
            int p;
            Console.Write("Depo number              : ");
            n = Console.ReadLine();
            Console.Write("Date in format dd//mm//yy: ");
            t = Console.ReadLine();
            Console.Write("Start                    : ");
            s = Console.ReadLine();
            Console.Write("Destination              : ");
            d = Console.ReadLine();
            Console.Write("no of adults             : ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------APSRTC---------");
            Console.WriteLine();
            Console.WriteLine("depo number:" + n);
            Console.WriteLine();
            Console.WriteLine("date:" + t);
            Console.WriteLine();
            Console.WriteLine("from  " + s + "  to   " + d);
            Console.WriteLine();
            Console.WriteLine("A:"+p + " X " + "40" + "    =    "+ (p * 40));
            Console.WriteLine();
            Console.WriteLine("        Total=      " + (p * 40));
            Console.WriteLine("        HAPPY JOURNEY       ");
            Console.WriteLine("        Non Transferable     ");
        }
    }
}