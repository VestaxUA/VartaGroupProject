using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.UI;

public class ActionsButton : MonoBehaviour
{
    [SerializeField]
    private bool physical;

    private GameObject player;
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => AttachCallback(temp));
        player = GameObject.FindGameObjectWithTag("Player");
    }


    // Update is called once per frame
    private void AttachCallback(string btn)
    {
        
        if (btn.CompareTo("SimpleAttackButton") == 0)
        {
            player.GetComponent<FighterAction>().SelectAttack("melee");

        } else if (btn.CompareTo("EnergyAttackButton") == 0)
        {
            player.GetComponent<FighterAction>().SelectAttack("range");
        } else
        {
            player.GetComponent<FighterAction>().SelectAttack("run");
        }



    }


}
