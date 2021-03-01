using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSHER : MonoBehaviour
{
    // FOR PHYSICS CONTROL
    Rigidbody2D myBody; //the body...
    public float power; //to adjust the power >:)

    // Start is called before the first frame update
    void Start()
    {
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
            // to go woosh with physics >:) ...   

            Debug.Log("WOOSH");
            // to prove it DID push and IS pushing..!! 
        }
    }


}
