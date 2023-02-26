namespace D15_inlämning__objekt_och_git_
{
    internal class Program
    {

        public class grundamne
        {
            public string namn, atomnr, typ;
            public double smaltpunkt, kokpunkt;


            public void print()
            {
                Console.WriteLine("Grundämne: "+ namn);
                Console.WriteLine("  typ: "+ typ);
                Console.WriteLine("  smältpunkt: "+ smaltpunkt);
                Console.WriteLine("  kokpunkt: "+ kokpunkt);
                Console.WriteLine("");
            }
        }
            
        static void Main(string[] args)
        {
            grundamne syre = new grundamne()
            { namn = "syre", atomnr = " 8", typ = "ickemetal ", smaltpunkt = 54.36, kokpunkt = 90.188 };
            grundamne järn = new grundamne()
            { namn = "järn ", atomnr = "26", typ = "metall", smaltpunkt = 1811, kokpunkt = 3134 };
            grundamne guld = new grundamne()
            { namn = "guld", atomnr = "79", typ = "metall", smaltpunkt = 1337.33, kokpunkt = 3243 };

            //syre.print();
            //järn.print();
            //guld.print();
            grundamne väte = new grundamne()
            { namn = "väte", atomnr = " 1", typ = "ickemetall", smaltpunkt = 13.99, kokpunkt = 20.271 };
            grundamne brom = new grundamne()
            { namn = "brom", atomnr = "35", typ = "ickemetall", smaltpunkt = 265.8, kokpunkt = 332.0 };
            grundamne kvicksilver = new grundamne()
            { namn = "kvicksilver", atomnr = "80", typ = "metall", smaltpunkt =  234.3210, kokpunkt = 629.88 };

            grundamne[] grundÄmnerna = { syre, järn, guld, väte, brom, kvicksilver };

            //forloop print
            foreach (grundamne E in grundÄmnerna)
            {
                E.print();
            }
            Console.WriteLine("_____________________________________________________");
            //forloop list of metal
            foreach (var m in grundÄmnerna)
            {
                if (m.typ == "metall")
                { Console.WriteLine(m.namn + " är en metall"); }
            }
            Console.WriteLine("_____________________________________________________");

            //forloop list of tempruter
            Console.WriteLine("Här är en lista med alla ämne som har\r\n " +
                  "en smältpunkt under 273.16 K och en kokpunkt över 273.16");

            foreach (var temp in grundÄmnerna)
            {
                if(temp.smaltpunkt < 273.16 && temp.kokpunkt > 273.16)
                { Console.WriteLine(temp.namn); }
            }
            Console.WriteLine("_____________________________________________________");

            Console.WriteLine("Tack att du använder vår tjänst. ");
        }
    }
}