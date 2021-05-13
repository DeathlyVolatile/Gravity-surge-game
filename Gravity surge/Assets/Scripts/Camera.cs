using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    public GameObject trigger;
    public GameObject Cam;
    public GameObject Cam2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        
            Cam.SetActive(false);
            Cam2.SetActive(true);
        
    }
}
