using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HL_Upgrade_Manager : MonoBehaviour
{
    public HL_Weapon_Equipted instaled_Weapon;
    public HL_Weapon_Equipted Cannon_WepReference = HL_Weapon_Equipted.FromKey(WeaponKey.ExplosiveCannon);
    public HL_Weapon_Equipted Rot_WepReference = HL_Weapon_Equipted.FromKey(WeaponKey.RotaryCannon);
    public HL_Weapon_Equipted Quad_WepReference = HL_Weapon_Equipted.FromKey(WeaponKey.QuadMachineGun);



    [Header("Power Core Status")]
    public HL_Upgrade_Enum instaled_PoweCore;
    public int in_PowerCore_Level = 1;
    public int baseCore_Points = 0;

    public int in_CorePoint
    {
        get
        {
            int ret = baseCore_Points;

            if (instaled_PoweCore != null) ret += instaled_PoweCore.added_corePoints;
            return ret;
        }
        set
        { }
    }
    //--

    [Header("Turret Speed Status")]
    public int in_TurretSpeed_Level = 1;
    public HL_Upgrade_Enum instaled_TrurretRotationSlot;
    public float in_Base_Speed;
    public float in_Speed_Modifier
    {
        get
        {
            float ret = in_Base_Speed;

            if (instaled_TrurretRotationSlot != null) ret += instaled_TrurretRotationSlot.added_Speed_Mod;
            if (instaled_Weapon != null) ret += instaled_Weapon.WeaponBase_RotSpeed;
            return ret;
        }
        set
        { }
    }


    [Header("Turret Reload Status")]
    public int in_TurretReload_Level;
    public HL_Upgrade_Enum Instaled_Reload_Modifier;
    public float fl_Base_Reload;
    public float fl_Relod_Modifier
    {
        get
        {
            float ret = fl_Base_Reload;
            if (Instaled_Reload_Modifier != null) ret += Instaled_Reload_Modifier.added_Reload_Mod;
            if (instaled_Weapon != null) ret += instaled_Weapon.WeaponBase_ReloadSpeed;
            return ret;
        }
        set { }
    }


    [Header("Fire Rate Status")]
    public int in_FireRate_Level;
    public HL_Upgrade_Enum instaled_FireRate_Modifier;
    public float fl_Base_FireRate;
    public float fl_FireRate_Modifier
    {
        get
        {
            float ret = fl_Base_FireRate;
            if (instaled_FireRate_Modifier != null) ret += instaled_FireRate_Modifier.added_Fire_Rate_Mod;
            if (instaled_Weapon != null) ret += instaled_Weapon.WeaponBase_FireRate;
            return ret;
        }
        set { }
    }


    [Header("Magazine Status")]
    public int in_Magazine_Level = 0;
    public HL_Upgrade_Enum instaled_Magazine;


    public int in_base_Mag_size;
    public int in_Magazine_Modifier
    {
        get
        {
            int ret = in_base_Mag_size;
            if (instaled_Magazine != null && instaled_Weapon != null)
            {

                if (instaled_Weapon.WeaponKeyRef == Cannon_WepReference.WeaponKeyRef) ret += instaled_Magazine.added_Cannon_Mag;

                if (instaled_Weapon.WeaponKeyRef == Rot_WepReference.WeaponKeyRef)
                {
                    ret += instaled_Magazine.added_Rot_Mag;
                }
                if (instaled_Weapon.WeaponKeyRef == Quad_WepReference.WeaponKeyRef)
                {
                    ret += instaled_Magazine.added_Quad_Mag;
                }
            }
            return ret;
        }
    }

    [Header("Ammo Dump Status")]
    public int in_AmmoDump_Level = 0;
    public HL_Upgrade_Enum instaled_AmmoDump;
    public int in_Base_AmmoDump;
    public int in_AmmoDump_Modifier
    {
        get
        {
            int ret = in_Base_AmmoDump;
            if (instaled_AmmoDump != null && instaled_Weapon != null)
            {

                if (instaled_Weapon.WeaponKeyRef == Cannon_WepReference.WeaponKeyRef) ret += instaled_AmmoDump.added_Cannon_Dump;

                if (instaled_Weapon.WeaponKeyRef == Rot_WepReference.WeaponKeyRef)
                {
                    ret += instaled_AmmoDump.added_Rot_Dump;
                }
                if (instaled_Weapon.WeaponKeyRef == Quad_WepReference.WeaponKeyRef)
                {
                    ret += instaled_AmmoDump.added_Quad_Dump;
                }
            }
            return ret;
        }
    }





    [Header("Amunition Upgrade Status")]
    public int in_Ammo_Level = 0;
    public HL_Upgrade_Enum Instaled_Ammo_Upgrade;
    public int in_Base_Inpact_Ammo;
 

    public int in_InpactAmmo_Modifier
    {
        get
        {

            int ret = in_Base_Inpact_Ammo;
            if (Instaled_Ammo_Upgrade != null && instaled_Weapon != null)
            {

                if (instaled_Weapon.WeaponKeyRef == Cannon_WepReference.WeaponKeyRef)
                {
                    ret += Instaled_Ammo_Upgrade.added_CannonInpactAmmo_Mod;
                    ret += instaled_Weapon.WeaponBase_InpactDamage;

                }
                if (instaled_Weapon.WeaponKeyRef == Rot_WepReference.WeaponKeyRef)
                {
                    ret += Instaled_Ammo_Upgrade.added_RotInpactAmmo_Mod;
                    ret += instaled_Weapon.WeaponBase_InpactDamage;
                }
                if (instaled_Weapon.WeaponKeyRef == Quad_WepReference.WeaponKeyRef)
                {
                    ret += Instaled_Ammo_Upgrade.added_QuadInpactAmmo_Mod;
                    ret += instaled_Weapon.WeaponBase_InpactDamage;
                }
            }
            return ret;
        }
    }

    public int in_Base_AOE_Ammo;
    public int in_AOE_Ammo_Modifier
    {
        get
        {
            int ret = in_Base_AOE_Ammo;
            if (Instaled_Ammo_Upgrade != null && instaled_Weapon != null)
            {

                if (instaled_Weapon.WeaponKeyRef == Cannon_WepReference.WeaponKeyRef)
                {
                    ret += Instaled_Ammo_Upgrade.added_Cannon_AOE_Ammo_Mod;
                    ret += instaled_Weapon.WeaponBase_AoeDamage;

                }
                if (instaled_Weapon.WeaponKeyRef == Rot_WepReference.WeaponKeyRef)
                {
                    ret += Instaled_Ammo_Upgrade.added_Rot_AOE_Ammo_Mod;
                    ret += instaled_Weapon.WeaponBase_AoeDamage;
                }
                if (instaled_Weapon.WeaponKeyRef == Quad_WepReference.WeaponKeyRef)
                {
                    ret += Instaled_Ammo_Upgrade.added_Quad_AOE_Ammo_Mod;
                    ret += instaled_Weapon.WeaponBase_AoeDamage;
                }
            }
            return ret;
        }
    }

    // Use this for initialization
    void Start()
    {
       // instaled_Weapon = HL_Weapon_Equipted.FromKey(WeaponKey.RotaryCannon);
    }

    // Update is called once per frame
    void Update()
    {
        //TestUpgrades();
        //testMagDUmp();

    }



    // Function for testing upgrades added and modifiers
    void TestUpgrades()
    {
        if (Input.GetKeyDown("t"))
        {
            in_PowerCore_Level++;
        }
        if (in_PowerCore_Level == 1)
        {
            instaled_PoweCore = HL_Upgrade_Enum.FromKey(UpgradeKey.PoerCoreLevel_1);
        }
        if (in_PowerCore_Level == 2)
        {
            instaled_PoweCore = HL_Upgrade_Enum.FromKey(UpgradeKey.PoerCoreLevel_2);
        }
        if (in_PowerCore_Level == 3)
        {
            instaled_PoweCore = HL_Upgrade_Enum.FromKey(UpgradeKey.PoerCoreLevel_3);
        }
        if (in_PowerCore_Level == 4)
        {
            instaled_PoweCore = HL_Upgrade_Enum.FromKey(UpgradeKey.PoerCoreLevel_4);
        }
        if (in_PowerCore_Level == 5)
        {
            instaled_PoweCore = HL_Upgrade_Enum.FromKey(UpgradeKey.PoerCoreLevel_5);
        }
        // print(in_PowerCore_Level);

        // print(in_CorePoint);
        if (Input.GetKeyDown("y"))
        {
            baseCore_Points--;
        }

        if (Input.GetKeyDown("u"))
        {
            in_TurretSpeed_Level++;
        }
        if (in_TurretSpeed_Level == 1)
        {
            instaled_TrurretRotationSlot = HL_Upgrade_Enum.FromKey(UpgradeKey.SpeedMod_1);
        }
        if (in_TurretSpeed_Level == 2)
        {
            instaled_TrurretRotationSlot = HL_Upgrade_Enum.FromKey(UpgradeKey.SpeedMod_2);
        }
        if (in_TurretSpeed_Level == 3)
        {
            instaled_TrurretRotationSlot = HL_Upgrade_Enum.FromKey(UpgradeKey.SpeedMod_3);
        }
        //  print(in_Base_Speed);

        //  print(in_Speed_Modifier);
        if (Input.GetKeyDown("i"))
        {
            in_Base_Speed--;
        }

        if (Input.GetKeyDown("o"))
        {
            instaled_Weapon = HL_Weapon_Equipted.FromKey(WeaponKey.QuadMachineGun);
            // Cannon_WepReference = HL_Weapon_Equipted.FromKey(WeaponKey.ExplosiveCannon);
        }

    }



    void testMagDUmp()
    {

        if (Input.GetKeyDown("g"))
        {
            in_Magazine_Level++;
        }

        if (in_Magazine_Level == 0)
        {
            instaled_Magazine = HL_Upgrade_Enum.FromKey(UpgradeKey.MagazineMod_0);
        }
        if (in_Magazine_Level == 1)
        {
            instaled_Magazine = HL_Upgrade_Enum.FromKey(UpgradeKey.MagazineMod_1);
        }
        if (in_Magazine_Level == 2)
        {
            instaled_Magazine = HL_Upgrade_Enum.FromKey(UpgradeKey.MagazineMod_2);
        }
        print(in_Magazine_Modifier);

        if (Input.GetKeyDown("g"))
        {
            in_AmmoDump_Level++;
        }

        if (in_Magazine_Level == 0)
        {
            instaled_AmmoDump = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoDumpMod_0);
        }
        if (in_AmmoDump_Level == 1)
        {
            instaled_AmmoDump = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoDumpMod_1);
        }
        if (in_AmmoDump_Level == 2)
        {
            instaled_AmmoDump = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoDumpMod_2);
        }
        print(in_AmmoDump_Modifier);

        // damage modifier testing

        if (Input.GetKeyDown("l"))
        {
            in_Ammo_Level++;
        }

        if (in_Ammo_Level == 0)
        {
            Instaled_Ammo_Upgrade = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoUpgrade_Mod_0);
        }
        if (in_Ammo_Level == 1)
        {
            Instaled_Ammo_Upgrade = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoUpgrade_Mod_1);
        }

        print(in_InpactAmmo_Modifier);
        print(in_AOE_Ammo_Modifier);
    }
}
