using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
     public DialogueManager Dialogue;
    // Start is called before the first frame update
    void Start()
    {
        if (Dialogue.NameText.text=="Macaron"){
          //  Dialogue.Audio=GameObject.FindGameObjectWithTag("playervoce").GetComponent<AudioSource>();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
