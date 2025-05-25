using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360_Final
{
    public interface IAbstractWeaponFactory
    {
        IKineticWeapon GetKineticWeapon();
        IProjectileWeapon GetProjectileWeapon();
        IBeamWeapon GetBeamWeapon();
    }
}
