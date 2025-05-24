using CSC360_Final.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360_Final.Weapon
{
    public class BeamWeapon : IBeamWeapon
    {
        public Weapon GetWeapon()
        {
            return new()
            {

            };
        }
    }
}
