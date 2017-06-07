using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HL_Upgrade_Asigment : MonoBehaviour {
    public HL_Upgrade_Manager UP_Manager;
   public GameObject holder;
    public GameObject Quad;
    public GameObject rot;
    public GameObject cannon;



    private void Start()
    {
        UP_Manager = holder.GetComponent<HL_Upgrade_Manager>();
        UP_Manager.instaled_Weapon = HL_Weapon_Equipted.FromKey(WeaponKey.RotaryCannon);
        UP_Manager.instaled_PoweCore = HL_Upgrade_Enum.FromKey(UpgradeKey.PoerCoreLevel_1);
        UP_Manager.instaled_Magazine = HL_Upgrade_Enum.FromKey(UpgradeKey.MagazineMod_0);
        UP_Manager.instaled_AmmoDump = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoDumpMod_0);
        UP_Manager.Instaled_Ammo_Upgrade = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoUpgrade_Mod_0);
        Quad.SetActive(false);
        rot.SetActive(true);
        cannon.SetActive(false);
    }
    public void EquptRot()
    {
        UP_Manager.instaled_Weapon = HL_Weapon_Equipted.FromKey(WeaponKey.RotaryCannon);
        print("rot");
        reset();
             Quad.SetActive(false);
        rot.SetActive(true);
        cannon.SetActive(false);
}
    public void EquptCannon()
    {
        UP_Manager.instaled_Weapon = HL_Weapon_Equipted.FromKey(WeaponKey.ExplosiveCannon);
        print("cann");
        reset();
        Quad.SetActive(false);
        rot.SetActive(false);
        cannon.SetActive(true);
    }
    public void EquptQuad()
    {
        UP_Manager.instaled_Weapon = HL_Weapon_Equipted.FromKey(WeaponKey.QuadMachineGun);
        print("quad");
        reset();
        Quad.SetActive(true);
        rot.SetActive(false);
        cannon.SetActive(false);
    }
    public void EquptPowerCore_1()
    {
        UP_Manager.instaled_PoweCore = HL_Upgrade_Enum.FromKey(UpgradeKey.PoerCoreLevel_1);
    }
    public void EquptPowerCore_2()
    {
        UP_Manager.instaled_PoweCore = HL_Upgrade_Enum.FromKey(UpgradeKey.PoerCoreLevel_2);
    }
    public void EquptPowerCore_3()
    {
        UP_Manager.instaled_PoweCore = HL_Upgrade_Enum.FromKey(UpgradeKey.PoerCoreLevel_3);
    }
    public void EquptPowerCore_4()
    {
        UP_Manager.instaled_PoweCore = HL_Upgrade_Enum.FromKey(UpgradeKey.PoerCoreLevel_4);
    }

    public void EquptPowerCore_5()
    {
        UP_Manager.instaled_PoweCore = HL_Upgrade_Enum.FromKey(UpgradeKey.PoerCoreLevel_5);
    }
    public void SpeedMod_1()
    {
        UP_Manager.instaled_TrurretRotationSlot = HL_Upgrade_Enum.FromKey(UpgradeKey.SpeedMod_1);
    }
    public void SpeedMod_2()
    {
        UP_Manager.instaled_TrurretRotationSlot = HL_Upgrade_Enum.FromKey(UpgradeKey.SpeedMod_2);
    }
    public void SpeedMod_3()
    {
        UP_Manager.instaled_TrurretRotationSlot = HL_Upgrade_Enum.FromKey(UpgradeKey.SpeedMod_3);

    }
    public void MagazineMod_1()
    {
        UP_Manager.instaled_Magazine = HL_Upgrade_Enum.FromKey(UpgradeKey.MagazineMod_1);

    }
    public void MagazineMod_2()
    {
        UP_Manager.instaled_Magazine = HL_Upgrade_Enum.FromKey(UpgradeKey.MagazineMod_2);

    }
    public void MagazineMod_3()
    {
        UP_Manager.instaled_Magazine = HL_Upgrade_Enum.FromKey(UpgradeKey.MagazineMod_3);

    }
    public void MagazineMod_4()
    {
        UP_Manager.instaled_Magazine = HL_Upgrade_Enum.FromKey(UpgradeKey.MagazineMod_4);

    }
    public void AmmoDumpMod_1()
    {
        UP_Manager.instaled_AmmoDump = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoDumpMod_1);

    }
    public void AmmoDumpMod_2()
    {

        UP_Manager.instaled_AmmoDump = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoDumpMod_2);
    }
    public void AmmoDumpMod_3()
    {
        UP_Manager.instaled_AmmoDump = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoDumpMod_3);

    }
    public void AmmoDumpMod_4()
    {

        UP_Manager.instaled_AmmoDump = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoDumpMod_4);
    }
    public void AmmoUpgrade_Mod_1()
    {
        UP_Manager.Instaled_Ammo_Upgrade = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoUpgrade_Mod_1);

    }
    public void AmmoUpgrade_Mod_2()
    {

        UP_Manager.Instaled_Ammo_Upgrade = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoUpgrade_Mod_2);
    }
    public void AmmoUpgrade_Mod_3()
    {

        UP_Manager.Instaled_Ammo_Upgrade = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoUpgrade_Mod_3);
    }
    public void AmmoUpgrade_Mod_4()
    {

        UP_Manager.Instaled_Ammo_Upgrade = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoUpgrade_Mod_4);
    }
    public void AmmoUpgrade_Mod_5()
    {
        UP_Manager.Instaled_Ammo_Upgrade = HL_Upgrade_Enum.FromKey(UpgradeKey.AmmoUpgrade_Mod_5);

    }



    void reset()
    {
        UP_Manager.in_Base_AmmoDump = 0;
        UP_Manager.in_base_Mag_size = 0;
       
    }
}


