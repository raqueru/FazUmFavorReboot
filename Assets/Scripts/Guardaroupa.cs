using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guardaroupa : MonoBehaviour
{
    public Quests Quests;

    // Start is called before the first frame update
    private Inventory _inventory;

    public GameObject sprite;
    public GameObject lixo;
    // Start is called before the first frame update
    void Start()
    {
        _inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Player" && Quests.quests[2] == true && _inventory.itemtag == "cestocomlixo")
        {
            if (Input.GetKeyDown("z"))
            {
                 lixo.gameObject.SetActive(true);

                sprite.transform.position = gameObject.transform.position;
                foreach (Transform child in _inventory.slots[0].transform)
                {
                    Destroy(child.gameObject);
                    _inventory.itemtag = "";


                }
                 gameObject.transform.GetChild(0).gameObject.SetActive(true);
                 
               
}}
}
}
