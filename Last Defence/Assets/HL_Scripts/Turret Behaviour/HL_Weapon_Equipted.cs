using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipedSlot
{
    CurrentWeapon,

}
public enum WeaponKey
{
    RotaryCannon,
    QuadMachineGun,
    ExplosiveCannon,
    
}
public class HL_Weapon_Equipted : HL_Weapon_Stats
{
    public EquipedSlot WeaponType;
    public WeaponKey WeaponKeyRef;

    public static HL_Weapon_Equipted FromKey(WeaponKey key)
    {
        HL_Weapon_Equipted ret = new HL_Weapon_Equipted();
        switch (key)
        {
          
            case WeaponKey.RotaryCannon:
                ret = new HL_Weapon_Equipted()
                {
                    WeaponType = EquipedSlot.CurrentWeapon,
                    WeaponKeyRef = WeaponKey.RotaryCannon,

                    WeaponBase_RotSpeed = 5,
                    WeaponBase_FireRate =0.5f,
                    WeaponBase_InpactDamage = 12,
                    WeaponBase_AoeDamage = 4,
                    WeaponBase_Piercing= 6,
                    WeaponBase_ReloadSpeed = 2,


                };
                break;
            case WeaponKey.QuadMachineGun:
                ret = new HL_Weapon_Equipted()
                {
                    WeaponType = EquipedSlot.CurrentWeapon,

                    WeaponKeyRef = WeaponKey.QuadMachineGun,

                    WeaponBase_RotSpeed = 5,
                    WeaponBase_FireRate = 0.2f,
                    WeaponBase_InpactDamage = 4,
                    WeaponBase_AoeDamage = 0,
                    WeaponBase_Piercing = 2,
                    WeaponBase_ReloadSpeed = 2,

                };
                break;
            case WeaponKey.ExplosiveCannon:
                ret = new HL_Weapon_Equipted()
                {
                    WeaponType = EquipedSlot.CurrentWeapon,

                    WeaponKeyRef = WeaponKey.ExplosiveCannon,
                    WeaponBase_RotSpeed = 5,
                    WeaponBase_FireRate = 1,
                    WeaponBase_InpactDamage = 6,
                    WeaponBase_AoeDamage = 24,
                    WeaponBase_Piercing = 0,
                    WeaponBase_ReloadSpeed = 2,
                };
                break;
        }
        return ret;

    }
}
