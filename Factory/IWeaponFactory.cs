using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360_Final
{
    public class IWeaponFactory : IAbstractWeaponFactory
    {
        public IBeamWeapon GetBeamWeapon()
        {
            return new BeamWeapon();
        }

        public IKineticWeapon GetKineticWeapon()
        {
            return new KineticWeapon();
        }

        public IProjectileWeapon GetProjectileWeapon()
        {
            return new ProjectileWeapon();
        }
    }
}
