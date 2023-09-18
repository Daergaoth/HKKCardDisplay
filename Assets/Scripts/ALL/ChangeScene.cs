using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadARCardScanScene()
    {
        SceneManager.LoadScene("ARCardScan");
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void ExitApp()
    {
        Debug.Log("You have quit the app.");
        Application.Quit();
    }
}
