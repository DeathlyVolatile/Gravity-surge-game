using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject ricky;
    public GameObject menus;
    public GameObject Control;
    public void start()
    {
        SceneManager.LoadScene(1);
    }
    public void quit()
    {
        Application.Quit();
        ricky.SetActive(false);
    }
    public void controlls()
    {
        menus.SetActive(false);
        Control.SetActive(true);

    }
    public void menu()
    {
        Control.SetActive(false);
        menus.SetActive(true);
    }
}
