using Hominum.Model.IMaslow;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hominum.Model.Maslow
{
    interface IPrimaryNeeds : ICommonMaslow
    {
        int Att_Eat { get; set; }
        int Att_Sleep { get; set; }
        int Att_Breathe { get; set; }
        int Att_Hydrate { get; set; }
        void Eat();
        void Sleep();
        void Breathe();
        void Hydrate();
        bool Reproduce(List<Hominum> Value);
        void Lives(Hominum value, ref int Food, ref int Water);
    }
}
