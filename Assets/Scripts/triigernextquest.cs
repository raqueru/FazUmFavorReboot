using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triigernextquest : MonoBehaviour
{
     
    public Quests quests;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerStay2D (Collider2D collider) {
          if (collider.tag =="Player"&&quests.quests[1]==true){
         quests.quests[2]=true;
         quests.quests[1]=false;
         gameObject.GetComponent<DialogueTrigger>().enabled=false;


     }
}
}
