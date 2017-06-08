using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HL_Turret_System : MonoBehaviour
{

    [Header("Ratation Proprieties")]
    public bool Invert_Mouse;
    public float mouseSensisivity = 5.0f;
    public float Up_Down_Clamp;
    public float Left_Right_Clamp;
    public HL_Upgrade_Manager UP_Manager;
    Vector2 mouselook;
    Vector2 smothV;
    GameObject turret;

    [Header("Reload Proprieties")]
    float reloadTime;

    [Header("Fire Rate Proprieties")]

    public Camera MyCamera;

    public ParticleSystem Flash;
    public GameObject Inpact;
    private  float Fire_Delay;


    public GameObject[] AOETargets;
    public List<GameObject> TargetsInRange = new List<GameObject>();
    public GameObject OriginTarget;




    // Use this for initialization
    void Start()
    {
        UP_Manager = gameObject.GetComponent<HL_Upgrade_Manager>();
       
        turret = this.transform.parent.gameObject;
        //Deactivate();
    }
    // Update is called once per frame
    void Update()
    {
        if (HL_Level_Manager.instance.bl_Static == false)
        {
            //constant functions that have to be triggered once per frame
            Turret_Movement();
            //Turret_Reload();
            Turret_Fire();
            //
        }
    }
    // this function looks at managing the rotation of the turret and camera.
    void Turret_Movement()
    {
        // this function takes the speed value from all the upgrades and base and makes the mouse lerp / move to the apropriate cordonates
        // of the maouse. 
        var curentPos = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        curentPos = Vector2.Scale(curentPos, new Vector2(UP_Manager.in_Speed_Modifier / mouseSensisivity, UP_Manager.in_Speed_Modifier / mouseSensisivity));
        smothV.x = Mathf.Lerp(smothV.x, curentPos.x, 1f / mouseSensisivity);
        smothV.y = Mathf.Lerp(smothV.y, curentPos.y, 1f / mouseSensisivity);
        mouselook += smothV;
        // this clamps the rotation of the campera up and down, left and right.
        mouselook.y = Mathf.Clamp(mouselook.y, -Up_Down_Clamp, Up_Down_Clamp);
        mouselook.x = Mathf.Clamp(mouselook.x, -Left_Right_Clamp, Left_Right_Clamp);
        //
        // this apply the roatiaon to the camera and the turret that it is atached to.
        transform.localRotation = Quaternion.AngleAxis(-mouselook.y, Vector3.right);
        turret.transform.localRotation = Quaternion.AngleAxis(mouselook.x, turret.transform.up);
    }

    // this functions manages the automatic and manual reload of the turret
    void Turret_Fire()
    {
        if (UP_Manager.in_Magazine_Modifier <= 0)
        {
            reloadTime += Time.deltaTime;
            
            if (reloadTime >= UP_Manager.instaled_Weapon.WeaponBase_ReloadSpeed)
            {
                Turret_Reload();
            }
        }
        if (Input.GetButton("Fire1") && Time.time >= Fire_Delay)
        {
            if (UP_Manager.in_Magazine_Modifier > 0)
            {
                Shoot();
            }
        }
        else Flash.Stop(); 
    }
    void Shoot()
    {

        // Trigger Flash when Fiering and add next time to shot
        Flash.Play();
        UP_Manager.in_base_Mag_size--;
        
        Fire_Delay = Time.time + UP_Manager.fl_FireRate_Modifier;
        //Internal_Fire_Rate = Time.deltaTime;
        RaycastHit hit;
        if (Physics.Raycast(MyCamera.transform.position, MyCamera.transform.forward, out hit))
        {
            if (hit.transform.tag == "Target")
            {
                HL_TEmp_Enemy_Health target = hit.transform.GetComponent<HL_TEmp_Enemy_Health>();
                if (target != null)
                {
                    OriginTarget = target.gameObject;
                    
                    target.ReviceDamage(UP_Manager.in_InpactAmmo_Modifier);
                    AOETargets = GameObject.FindGameObjectsWithTag("Target");
                    DoAOEDamage();
                }
            }
            GameObject inpactEffect = Instantiate(Inpact, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(inpactEffect, 2f);
        }
    }
    void Turret_Reload()
    {
        if (UP_Manager.in_AmmoDump_Modifier > 0)
        {
            UP_Manager.in_base_Mag_size = 0;
            UP_Manager.in_Base_AmmoDump--;
            reloadTime = 0;
        }
    }
    void DoAOEDamage()
    {
       
        float distance = 10.0f;

        Vector3 This_position = OriginTarget.transform.position;

        foreach (GameObject go in AOETargets)
        {
            Vector3 diff = go.transform.position - This_position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                GameObject addGo = go;
                TargetsInRange.Add(go);
                distance = curDistance;

            }
        }
        for (int i = 0; i < TargetsInRange.Count; i++)
        {
            TargetsInRange[i].GetComponent<HL_TEmp_Enemy_Health>().ReviceDamage(UP_Manager.in_AOE_Ammo_Modifier);
        }
        TargetsInRange.Clear();
    }

}
