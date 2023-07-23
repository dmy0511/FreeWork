using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void SceneLoad(string Ex)
    {
        SceneManager.LoadScene(Ex);
    }

    public void SceneLoad1(string Enter)
    {
        SceneManager.LoadScene(Enter);
    }

    public void SceneLoad2(string Game)
    {
        SceneManager.LoadScene(Game);
    }
}
