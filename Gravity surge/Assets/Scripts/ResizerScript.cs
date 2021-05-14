using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizerScript : MonoBehaviour
{
    public GameObject player;

    public Player script;

    public Sprite offline;
    public Sprite online;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag =="Resizer" ) 
        {
            if (script.small == false)
            {
              transform.localScale = new Vector3(script.smallSize,script.smallSize,script.smallSize);

                

                GameObject.Find("Resizer").GetComponent<BoxCollider2D>().enabled = false;

                script.small = true;
                StartCoroutine(EnableBox(4.0f));

            }
            else if (script.small == true)
            {
                transform.localScale = new Vector3(script.normalSize,script.normalSize,script.normalSize);

                

                GameObject.Find("Resizer").GetComponent<BoxCollider2D>().enabled = false;

                script.small = false;
                StartCoroutine(EnableBox(4.0f));
            }
            
        }
       


    }

    private IEnumerator EnableBox(float waitTime)
    {
        GameObject.Find("Resizer").GetComponent<SpriteRenderer>().sprite = offline;

        yield return new WaitForSeconds(waitTime);

        GameObject.Find("Resizer").GetComponent<BoxCollider2D>().enabled = true;

        GameObject.Find("Resizer").GetComponent<SpriteRenderer>().sprite = online;
    }




}
