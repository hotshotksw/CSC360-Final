﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360_Final
{
    public class BeamWeapon : IBeamWeapon
    {
        public Weapon GetWeapon()
        {
            return new()
            {
                weaponName = "IS-BEMR",
                projectileType = Weapon.ProjectileType.BEAM,
                maxCapacity = 15,
                fireRate = 2.5f
            };
        }
    }
}
