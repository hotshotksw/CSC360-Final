using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new IWeaponFactory());

            Weapon rifle = client.GetKineticWeapon();

            Console.WriteLine(
                "\nRifle Information" +
                "\nName: " + rifle.weaponName +
                "\nProjectile Type: " + rifle.projectileType.ToString() +
                "\nAmmo Capacity: " + rifle.maxCapacity
            );

            Weapon beam = client.GetBeamWeapon();

            Console.WriteLine(
                "\nEnergy Weapon Information" +
                "\nName: " + beam.weaponName +
                "\nProjectile Type: " + beam.projectileType.ToString() +
                "\nAmmo Capacity: " + beam.maxCapacity
            );

            Weapon rocketLauncher = client.GetProjectileWeapon();

            Console.WriteLine(
                "\nRifle Information" +
                "\nName: " + rocketLauncher.weaponName +
                "\nProjectile Type: " + rocketLauncher.projectileType.ToString() +
                "\nAmmo Capacity: " + rocketLauncher.maxCapacity
            );
        }
    }
}
