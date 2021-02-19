using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject[] slots;
    private SlothDialogue Sloth;
    public string itemtag;
    // Start is called before the first frame update
    void Start()
    {
        Sloth = GameObject.FindGameObjectWithTag("Sloth").GetComponent<SlothDialogue>();
    }

    // Update is called once per frame
    void Update()
    {
      dropItem();
    }

    void dropItem(){
        foreach(Transform child in slots[0].transform){
              if (Sloth.GotItem == true){
                  Debug.Log("Aa");
                  Destroy(child.gameObject);
                  itemtag="";
                  Sloth.GotItem=false;
        }
        
        

    }
}
}
