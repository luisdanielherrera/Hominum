using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hominum.Model;

namespace Hominum.App
{
    public class Engine
    {
        public List<Model.Hominum> Hominums { get; set; }
        public int Food { get; set; } = 100;
        public int Water { get; set; } = 100;
        public int Oxigen { get; set; } = 100;
        public int Days { get; set; }
        public void Initialized()
        {
            try
            {
                Hominums = new List<Model.Hominum>();
                for (int i = 0; i < 10; i++)
                {
                    Hominums.Add(new Model.Hominum());
                }
                LifeCycle();
            }
            catch (Exception ex)
            {
                int x = 0;
            }
        }
        public void LifeCycle()
        {
            int Food = this.Food;
            int Water = this.Water;
            while (Hominums.Any(i => i.Alive == true))
            {
                foreach (var Hominum in Hominums)
                {
                    Hominum.PrimaryNeeds.Lives(Hominum, ref Food, ref Water);
                    this.Food = Food;
                    this.Water = Water;
                }
                Days++;
            }
            Console.WriteLine("Find del Mundo.");
        }
    }
}
