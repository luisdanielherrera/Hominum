using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hominum.Model.Maslow
{
    public class PrimaryNeeds : IPrimaryNeeds
    {
        public int Att_Eat { get; set; }
        public int Att_Sleep { get; set; }
        public int Att_Breathe { get; set; }
        public int Att_Hydrate { get; set; }
        public void Breathe()
        {
            Att_Breathe += 5;
        }

        public void Eat()
        {
            Att_Eat += 5;
        }

        public void Hydrate()
        {
            Att_Hydrate += 5;
        }
        public void Sleep()
        {
            Att_Sleep += 5;
        }

        public void Initialized()
        {
            Att_Eat = 100;
            Att_Sleep = 100;
            Att_Breathe = 100;
            Att_Hydrate = 100;
        }

        public void Lives(Hominum Hominum, ref int Food, ref int Water)
        {
            Att_Eat--;
            Att_Sleep--;
            Att_Breathe--;
            Att_Hydrate--;
            if (Att_Eat == 0 || Att_Sleep == 0 || Att_Breathe == 0 || Att_Hydrate == 0)
            {
                Hominum.Alive = false;
                Console.WriteLine($"{Hominum.Name } is dead.");
            }
            if (Food > 0)
            {
                Food--;
            }
            if (Water > 0)
            {
                Water--;
            }
        }

        public bool Reproduce(List<Hominum> Hominums)
        {
            if (Hominums.Any(i => i.Gender == Gender.Women))
            {
                return true;
            }
            return false;
        }
    }
}
