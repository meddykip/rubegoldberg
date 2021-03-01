using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehavior : MonoBehaviour
{
    // to hold + control the sprite...
    SpriteRenderer myRenderer;

    // COLOR CONTROL !!
    // change the ball's color after each gate
    // set in public to control it in Inspector...
    public Color waterColor;
    public Color sunColor;
    public Color loveColor;
    
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        //myRenderer will hold the sprite!
    }

    // Update is called once per frame
    void Update()
    {

    }

    // GATE COLLISIONS + COLOR CHANGERS!
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.name == "watergate"){ // if the ball collides with the WATER GATE...
            myRenderer.color = waterColor; // change it to water color!
            Debug.Log("RAINY DAY CONFIRMED"); // show the message to CONFIRM!
        } else if (other.gameObject.name == "sungate"){ // ELSE if the ball collides with SUN GATE...
            myRenderer.color = sunColor; // change it to sun color!
            Debug.Log("SUNNY DAY SONG"); // show the message to CONFIRM! : love livers rise up
        } else if (other.gameObject.name == "lovegate"){ // ELSE if the ball collides with LOVE GATE...
            myRenderer.color = loveColor; // change it to love color!
            Debug.Log("its killed or be killed"); // :)
        }
    }

}
