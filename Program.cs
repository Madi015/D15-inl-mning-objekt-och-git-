namespace D15_inlämning__objekt_och_git_
{
    internal class Program
    {

        public class grundamne
        {
            public string namn, atomnr, typ, smaltpunkt, kokpunkt;
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
            { namn = "syre", atomnr = " 8", typ = "ichemetal ", smaltpunkt = "54.36", kokpunkt = "90.188" };
            grundamne järn = new grundamne()
            { namn = "järn ", atomnr = "26", typ = "metall", smaltpunkt = "1811", kokpunkt = "3134" };
            grundamne guld = new grundamne()
            { namn = "guld", atomnr = "79", typ = "metall", smaltpunkt = "1337.33", kokpunkt = "3243" };

            syre.print();
            järn.print();
            guld.print();

            grundamne[] grundÄmnerna = { syre, järn, guld, null, null, null };
        }
    }
}