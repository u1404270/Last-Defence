using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UpgradeSlotType
{
    PowerCoreSlot,
    TrurretRotationSlot,
    ReloadSlot,
    ImprovedAmmoSlot,
    MagasineSlot,
    AmoDumpSlot,
    StunFieldSlot,
    AlchemicalRocketSlot,
}
public enum UpgradeKey
{
    PoerCoreLevel_1,
    PoerCoreLevel_2,
    PoerCoreLevel_3,
    PoerCoreLevel_4,
    PoerCoreLevel_5,

    SpeedMod_1,
    SpeedMod_2,
    SpeedMod_3,

    MagazineMod_0,
    MagazineMod_1,
    MagazineMod_2,
    MagazineMod_3,
    MagazineMod_4,

    AmmoDumpMod_0,
    AmmoDumpMod_1,
    AmmoDumpMod_2,
    AmmoDumpMod_3,
    AmmoDumpMod_4,

    AmmoUpgrade_Mod_0,
    AmmoUpgrade_Mod_1,
    AmmoUpgrade_Mod_2,
    AmmoUpgrade_Mod_3,
    AmmoUpgrade_Mod_4,
    AmmoUpgrade_Mod_5,

}
public class HL_Upgrade_Enum : HL_Upgrade_Stats
{
    public UpgradeSlotType UpgradeType;

    public static HL_Upgrade_Enum FromKey(UpgradeKey key)
    {
        HL_Upgrade_Enum ret = new HL_Upgrade_Enum();
        switch (key)
        {
            case UpgradeKey.PoerCoreLevel_1:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.PowerCoreSlot,
                    added_corePoints = 5,
                };
                break;
            case UpgradeKey.PoerCoreLevel_2:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.PowerCoreSlot,
                    added_corePoints = 10,
                };
                break;
            case UpgradeKey.PoerCoreLevel_3:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.PowerCoreSlot,
                    added_corePoints = 15,
                };
                break;
            case UpgradeKey.PoerCoreLevel_4:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.PowerCoreSlot,
                    added_corePoints = 20,
                };
                break;
            case UpgradeKey.PoerCoreLevel_5:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.PowerCoreSlot,
                    added_corePoints = 25,
                };
                break;

            // speed modifier for turret rotation and movement sent over to the Upgrade Manager
            case UpgradeKey.SpeedMod_1:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.TrurretRotationSlot,
                    added_Speed_Mod = 5,
                };
                break;

            case UpgradeKey.SpeedMod_2:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.TrurretRotationSlot,
                    added_Speed_Mod = 10,
                };
                break;

            case UpgradeKey.SpeedMod_3:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.TrurretRotationSlot,
                    added_Speed_Mod = 15,
                };
                break;
            case UpgradeKey.MagazineMod_0:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.MagasineSlot,
                    added_Cannon_Mag = 1,
                    added_Quad_Mag = 40,
                    added_Rot_Mag = 10,
                };
                break;
            case UpgradeKey.MagazineMod_1:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.MagasineSlot,
                    added_Cannon_Mag = 3,
                    added_Quad_Mag = 60,
                    added_Rot_Mag = 16,
                };
                break;
            case UpgradeKey.MagazineMod_2:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.MagasineSlot,
                    added_Cannon_Mag = 5,
                    added_Quad_Mag = 80,
                    added_Rot_Mag = 22,
                };
                break;
            case UpgradeKey.MagazineMod_3:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.MagasineSlot,
                    added_Cannon_Mag = 7,
                    added_Quad_Mag = 100,
                    added_Rot_Mag = 28,
                };
                break;
            case UpgradeKey.MagazineMod_4:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.MagasineSlot,
                    added_Cannon_Mag = 9,
                    added_Quad_Mag = 120,
                    added_Rot_Mag = 34,
                };
                break;

            case UpgradeKey.AmmoDumpMod_1:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.AmoDumpSlot,
                    added_Cannon_Dump = 25,
                    added_Quad_Dump = 8,
                    added_Rot_Dump = 16,
                };
                break;

            case UpgradeKey.AmmoDumpMod_2:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.AmoDumpSlot,
                    added_Cannon_Dump = 30,
                    added_Quad_Dump = 12,
                    added_Rot_Dump = 20,
                };
                break;
            case UpgradeKey.AmmoDumpMod_3:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.AmoDumpSlot,
                    added_Cannon_Dump = 35,
                    added_Quad_Dump = 12,
                    added_Rot_Dump = 24,
                };
                break;
            case UpgradeKey.AmmoDumpMod_4:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.AmoDumpSlot,
                    added_Cannon_Dump = 40,
                    added_Quad_Dump = 16,
                    added_Rot_Dump = 28,
                };
                break;
            case UpgradeKey.AmmoDumpMod_0:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.AmoDumpSlot,
                    added_Cannon_Dump = 20,
                    added_Quad_Dump = 4,
                    added_Rot_Dump = 12,
                };
                break;
            // ammo uprade
            case UpgradeKey.AmmoUpgrade_Mod_0:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.ImprovedAmmoSlot,
                    added_QuadInpactAmmo_Mod = 0,
                    added_RotInpactAmmo_Mod = 0,
                    added_CannonInpactAmmo_Mod = 0,

                    added_Quad_AOE_Ammo_Mod = 0,
                    added_Rot_AOE_Ammo_Mod = 0,
                    added_Cannon_AOE_Ammo_Mod = 0,
                };
                break;
            case UpgradeKey.AmmoUpgrade_Mod_1:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.ImprovedAmmoSlot,
                    added_QuadInpactAmmo_Mod = 10,
                    added_RotInpactAmmo_Mod = 10,
                    added_CannonInpactAmmo_Mod = 10,

                    added_Quad_AOE_Ammo_Mod = 0,
                    added_Rot_AOE_Ammo_Mod = 10,
                    added_Cannon_AOE_Ammo_Mod = 10,
                };
                break;
            case UpgradeKey.AmmoUpgrade_Mod_2:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.ImprovedAmmoSlot,
                    added_QuadInpactAmmo_Mod = 0,
                    added_RotInpactAmmo_Mod = 0,
                    added_CannonInpactAmmo_Mod = 0,

                    added_Quad_AOE_Ammo_Mod = 0,
                    added_Rot_AOE_Ammo_Mod = 0,
                    added_Cannon_AOE_Ammo_Mod = 0,
                };
                break;
            case UpgradeKey.AmmoUpgrade_Mod_3:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.ImprovedAmmoSlot,
                    added_QuadInpactAmmo_Mod = 0,
                    added_RotInpactAmmo_Mod = 0,
                    added_CannonInpactAmmo_Mod = 0,

                    added_Quad_AOE_Ammo_Mod = 0,
                    added_Rot_AOE_Ammo_Mod = 0,
                    added_Cannon_AOE_Ammo_Mod = 0,
                };
                break;
            case UpgradeKey.AmmoUpgrade_Mod_4:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.ImprovedAmmoSlot,
                    added_QuadInpactAmmo_Mod = 0,
                    added_RotInpactAmmo_Mod = 0,
                    added_CannonInpactAmmo_Mod = 0,

                    added_Quad_AOE_Ammo_Mod = 0,
                    added_Rot_AOE_Ammo_Mod = 0,
                    added_Cannon_AOE_Ammo_Mod = 0,
                };
                break;
            case UpgradeKey.AmmoUpgrade_Mod_5:
                ret = new HL_Upgrade_Enum()
                {
                    UpgradeType = UpgradeSlotType.ImprovedAmmoSlot,
                    added_QuadInpactAmmo_Mod = 0,
                    added_RotInpactAmmo_Mod = 0,
                    added_CannonInpactAmmo_Mod = 0,

                    added_Quad_AOE_Ammo_Mod = 0,
                    added_Rot_AOE_Ammo_Mod = 0,
                    added_Cannon_AOE_Ammo_Mod = 0,
                };
                break;
        }
        return ret;
    }
}

