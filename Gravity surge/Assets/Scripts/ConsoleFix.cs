using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleFix : MonoBehaviour
{
    public bool conOne = false;
    public bool conTwo = false;
    public bool gameWon = false;

    public Gamemanager gm;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     if ( conOne == true && conTwo == true)
        {
            gm.GameWon();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            conOne = true;
        }
        
    }
}   
