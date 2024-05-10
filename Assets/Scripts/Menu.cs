using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void SwitchScene(int buildIndex)
    {
        SceneManager.LoadScene(1);
    }

    public void StartScene(int buildIndex)
    {
        SceneManager.LoadScene(3);
    }
}
