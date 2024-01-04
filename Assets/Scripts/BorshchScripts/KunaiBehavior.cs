using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiBehavior : RangeWeaponBehavior
{
    KunaiControler kc;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        kc = FindAnyObjectByType<KunaiControler>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * kc.speed * Time.deltaTime;
    }
}
