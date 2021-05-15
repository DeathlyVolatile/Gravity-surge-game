using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public ConsoleFix cf;
    public Menu menu;

    public GameObject gameWonScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameWon()
    {
        gameWonScreen.SetActive(true);


    }
}
