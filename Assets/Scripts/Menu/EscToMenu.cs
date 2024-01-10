using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EscToMenu : MonoBehaviour
{
    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            SceneManager.LoadScene(0);
        }
    }
}
