using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiControler : WeaponControler
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
    {
        base.Attack();
        GameObject spawnedKunai = Instantiate(weaponData.Prefab);
        spawnedKunai.transform.position = transform.position;
        spawnedKunai.GetComponent<KunaiBehavior>().DirectionChecker(pm.lastMovedVector);
    }
}
