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

    // FOR PHYSICS CONTROL
    Rigidbody2D myBody; //the ball's body...
    public float power; //to adjust the ball's power >:)

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        //myRenderer will hold the sprite!

        myBody = gameObject.GetComponent<Rigidbody2D>();
        //myBody will hold the Rigidbody2D component...
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
           //myBody.AddForce((Vector3.right + Vector3.up) * power);
            
            myBody.AddForce((new Vector3(1, 0, 0) + new Vector3(0, 1 , 0)) * power); 
            // math...????   
            // it makes the ball goes woosh with physics >:) ...    
        }
    }

    // GATE COLLISIONS !
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
