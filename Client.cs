using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360_Final
{
    class Client
    {

        IAbstractWeaponFactory _weaponFactory;

        public Client(IAbstractWeaponFactory factory)
        {
            _weaponFactory = factory;
        }

        public Weapon GetKineticWeapon()
        {
            var weapon = _weaponFactory.GetKineticWeapon();
            return weapon.GetWeapon();
        }
        public Weapon GetBeamWeapon()
        {
            var weapon = _weaponFactory.GetBeamWeapon();
            return weapon.GetWeapon();
        }
        public Weapon GetProjectileWeapon()
        {
            var weapon = _weaponFactory.GetProjectileWeapon();
            return weapon.GetWeapon();
        }
    }
}
