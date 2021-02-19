using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adbook : MonoBehaviour
{
    private Inventory inventory;

    public Animator Animator;
    public GameObject itemButton;
    // Start is called before the first frame update
    void Start()
    {
         inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerStay2D (Collider2D other) {
         if (other.CompareTag("Player")&& Input.GetKeyDown("z") && inventory.itemtag=="book") {
              Animator.SetBool("hasbook",true);
              foreach (Transform child in inventory.slots[0].transform)
                {

                    Destroy(child.gameObject);
                    inventory.itemtag = "";

                }
             Instantiate(itemButton, inventory.slots[0].transform, false); // spawn the button so that the player can interact with it
                  
                    inventory.itemtag =itemButton.tag;

         }
         }
}
