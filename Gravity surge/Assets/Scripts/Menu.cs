using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject ricky;
    public void start()
    {
        SceneManager.LoadScene(1);
    }
    public void quit()
    {
        Application.Quit();
        ricky.SetActive(false);
    }

}
