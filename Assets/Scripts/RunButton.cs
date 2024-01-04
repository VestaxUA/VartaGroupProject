using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunButton : MonoBehaviour
{
    [SerializeField]
    private float runnningChance;
    public void tryRunning()
    {
        float randomNumber = Random.value;
        if (randomNumber < this.runnningChance)
        {
            SceneManager.LoadScene("WalkTestScene");
        }
        else
        {
            Debug.Log("RunNotSuccess");
            //GameObject.Find("TurnSystem").GetComponent<TurnSystem>().nextTurn();
        }
    }
}
