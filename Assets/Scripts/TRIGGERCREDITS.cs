using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRIGGERCREDITS : MonoBehaviour
{
     
     private Inventory inventory;

    public bool fimdejogo=false;
    // Start is called before the first frame update
    void Start()
    {
         inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerStay2D (Collider2D collider) {
          if (collider.tag =="Player" &&  Input.GetKeyDown("z") &&inventory.itemtag == "Broom"){
         fimdejogo=true;
         gameObject.transform.GetChild(0).gameObject.SetActive(true);
         



     }
}
}
