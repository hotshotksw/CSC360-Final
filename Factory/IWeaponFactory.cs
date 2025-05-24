using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360_Final.Factory
{
    public class IWeaponFactory : IAbstractWeaponFactory
    {
        public IBeamWeapon GetBeamWeapon()
        {
            return new NotImplementedException();
        }

        public IKineticWeapon GetKineticWeapon()
        {
            throw new NotImplementedException();
        }

        public IProjectileWeapon GetProjectileWeapon()
        {
            throw new NotImplementedException();
        }
    }
}
