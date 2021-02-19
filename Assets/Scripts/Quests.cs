using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quests : MonoBehaviour
{
    public bool[] quests;
    // Start is called before the first frame update
    void Start()
    {
        quests= new bool[4];
        for(int i=0;i<3;i++){
            quests[i]=false;
        }
    }

    // Update is called once per frame
    void Update()
    {
         
        
    }
}
