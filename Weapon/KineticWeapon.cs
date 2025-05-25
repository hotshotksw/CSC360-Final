using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360_Final
{
    public class KineticWeapon : IKineticWeapon
    {
        public Weapon GetWeapon()
        {
            return new()
            {
                weaponName = "3M-FMA",
                projectileType = Weapon.ProjectileType.KINETIC,
                maxCapacity = 100,
                fireRate = 0.5f
            };
        }
    }
}
