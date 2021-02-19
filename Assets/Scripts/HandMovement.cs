using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    // Start is called before the first frame update
      public float Movespeed;
      
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( gameObject.tag=="Left Hand"){
          Vector3 movement =new Vector3(Input.GetAxis("Horizontal letras"),Input.GetAxis("Vertical letras"),0f);
          
        transform.position+=movement*Time.deltaTime*Movespeed;  
        }
         else if ( gameObject.tag=="Right Hand"){
          Vector3 movement =new Vector3(Input.GetAxis("Horizontal setas"),Input.GetAxis("Vertical setas"),0f);
          
        transform.position+=movement*Time.deltaTime*Movespeed;  
        }
    }
    
     private void OnTriggerEnter2D(Collider2D other) {
            foreach(Transform child in gameObject.transform){
                if(child.tag=="Palma"){
                    if (other.gameObject.tag == "Palma"){
                  
                         Debug.Log("aa");
                  }
                }
                  
          }
     }
    }
 