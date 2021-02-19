using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    private Inventory inventory;
    public GameObject itemButton;
    private AudioSource Gotcha;
    
     
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        Gotcha= GameObject.FindGameObjectWithTag("sound").GetComponent<AudioSource>();
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player")&& Input.GetKeyDown("z") && inventory.itemtag=="") {
            // spawn the sun button at the first available inventory slot ! 

                     Gotcha.Play();
                    Instantiate(itemButton, inventory.slots[0].transform, false); // spawn the button so that the player can interact with it
                    Destroy(gameObject);
                    inventory.itemtag =gameObject.tag;
                   
                    
             
        }
    }
  
}