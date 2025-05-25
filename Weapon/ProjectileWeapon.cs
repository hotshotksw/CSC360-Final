using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360_Final
{
    public class ProjectileWeapon : IProjectileWeapon
    {
        public Weapon GetWeapon()
        {
            return new()
            {
                weaponName = "RAMP-500",
                projectileType = Weapon.ProjectileType.PROJECTILE,
                maxCapacity = 5,
                fireRate = 5f
            };
        }
    }
}
