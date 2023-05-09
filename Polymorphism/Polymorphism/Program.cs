using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        class Musician
        {
            public virtual void play_instrument()
            {

            }
        }

        class Guitarist : Musician
        {
            public override void play_instrument()
            {
                Console.WriteLine("Guitarist is playing a Guitar");
            }
        }

        class Pianist : Musician
        {
            public override void play_instrument()
            {
                Console.WriteLine("Pianist is playing a Piano");
            }
        }
        static void Main(string[] args)
        {
            Guitarist guitarist = new Guitarist();
            Pianist pianist = new Pianist();

            Musician[] musicians = { guitarist, pianist };
            
            foreach (Musician musician in musicians)
            {
                musician.play_instrument();
            }

        }
    }
}
