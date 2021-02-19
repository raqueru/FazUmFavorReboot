using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupHelper : MonoBehaviour


{
   public  Quests quests;

   public int quest;
   public string tagg;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        canbeholded();


    }

    private void canbeholded(){
        
        if (gameObject.tag==tagg&& quests.quests[quest]==false){
            gameObject.GetComponent<Pickup>().enabled=false;
        }
        else if (gameObject.tag==tagg&& quests.quests[quest]==true){
             gameObject.transform.GetChild(0).gameObject.SetActive(false);
             gameObject.transform.GetChild(1).gameObject.SetActive(true);
             gameObject.GetComponent<Pickup>().enabled=true;
              
        }
    }
}
