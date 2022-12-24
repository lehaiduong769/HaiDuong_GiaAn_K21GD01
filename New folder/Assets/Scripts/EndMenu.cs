using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void OnApplicationQuit()
    {
        {
            Application.Quit();
        }
    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
