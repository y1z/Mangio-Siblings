using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinScreenUI : MonoBehaviour
{

    public void LoadLevel(string level_name)
    {
        SceneManager.LoadScene(level_name);

    }

    public void Quit()
    {
        Application.Quit();
    }

}
