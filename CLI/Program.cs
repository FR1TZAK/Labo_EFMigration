using Repositories;
using System;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            //WickedAirSourceContext wc = new WickedAirSourceContext();
            WickedAirSourceContextDupe wc = new WickedAirSourceContextDupe();

            Console.WriteLine("SCAFFOLD COMPLETED");
            Console.WriteLine("1ST MIGRATION COMPLETED");
            Console.WriteLine("MIGRATION ADD TABLE CATERING COMPLETED");
        }
    }
}
