using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holdjunk : MonoBehaviour
{

    public Quests Quests;
    private Inventory _inventory;
    public SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        // sprite = GetComponent<SpriteRenderer>();
        _inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Quests.quests[2] == true && _inventory.itemtag == "Lixo")
        {
            if (Input.GetKeyDown("z"))
            {

                Instantiate(sprite, gameObject.transform.GetChild(0), true);

                sprite.transform.position = gameObject.transform.GetChild(0).transform.position;
                sprite.sortingOrder = 2;
                gameObject.tag = "cestocomlixo";
                foreach (Transform child in _inventory.slots[0].transform)
                {
                    Destroy(child.gameObject);
                    _inventory.itemtag = "";

                }

               
                gameObject.transform.GetChild(1).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).gameObject.SetActive(true);
                gameObject.GetComponent<Pickup>().enabled=true;

                 
            }

        }
    }
}
