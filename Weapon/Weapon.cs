using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360_Final
{
    public class Weapon
    {
        public enum ProjectileType
        {
            KINETIC,
            PROJECTILE,
            BEAM
        }

        public string weaponName;
        public ProjectileType projectileType;
        public int maxCapacity;
        public int currentCapacity;
        public float reloadSpeed;
        public float fireRate;
    }
}
