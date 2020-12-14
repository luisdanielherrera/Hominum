using Hominum.Model.Maslow;
using System;
using System.Collections.Generic;
using System.Text;
using Hominum.Util;

namespace Hominum.Model
{
    public class Hominum
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public bool Alive { get; set; }
        public PrimaryNeeds PrimaryNeeds { get; set; }
        public Hominum()
        {
            try
            {
                var rand = new Random();
                this.Gender = (Gender)rand.Next(0, 2);
                this.Alive = true;
                this.Name = HandlerNames.SetName(this.Gender);
                PrimaryNeeds = new PrimaryNeeds();
                PrimaryNeeds.Initialized();
            }
            catch(Exception ex)
            {
                var x = 0;
            }
            
        }
        public override string ToString()
        {
            return $"Name: {Name}, Gender: {Gender}, Alive: {Alive}, PrimaryNeeds: {PrimaryNeeds}";
        }
    }
}
