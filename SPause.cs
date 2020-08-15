using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPause : MonoBehaviour
{
    bool Paused = false;
    bool Speed = false;

    public void PauseGame()
    {

        if (Paused)
        {
            Time.timeScale = 1;
            Paused = false;
            Debug.Log("Pause");
        }
        else
        {
            Time.timeScale = 0;
            Paused = true;
            Debug.Log("Resume");
        }

    }
}
