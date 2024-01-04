using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterAction : MonoBehaviour
{
    private GameObject enemy;
    private GameObject player;

    [SerializeField]
    private GameObject meleePrefab;

    [SerializeField]
    private GameObject rangePrefab;

    private GameObject currentAttack;
    private GameObject meleeAttack;
    private GameObject rangeAttack;

    public void SelectAttack(string btn)
    {
        GameObject target = tag == "Player" ? enemy : player;
        if (tag == "Player")
        {
            target = enemy;
        }
        if(btn.CompareTo("melee") == 0)
        {
            Debug.Log("Punchin`");
        } else if (btn.CompareTo("range") == 0)
        {
            Debug.Log("Shootin`");
        } else
        {
            Debug.Log("Run");
        }
    }
}
