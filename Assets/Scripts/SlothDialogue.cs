using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlothDialogue : MonoBehaviour

{
    public Quests quests;
    private Inventory _inventory;
    public DialogueManager Dialogue;
    public bool GotItem = false;

    // Start is called before the first frame update
    void Start()
    {
        _inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    // Update is called once per frame
    void Update()
    {

        checkquest();
        checkitem();



    }
    void checkitem()
    {
        if (_inventory.itemtag == "Broom")
        {
            for (int i = 0; i < 8; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }

            gameObject.transform.GetChild(8).gameObject.SetActive(true);
         


        }

        else if (_inventory.itemtag == "WorkPencil")
        {

            for (int i = 0; i < 2; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }
            gameObject.transform.GetChild(2).gameObject.SetActive(true);

        }
        else if (_inventory.itemtag == "Lixo")
        {

            for (int i = 0; i < 4; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }

            gameObject.transform.GetChild(4).gameObject.SetActive(true);
        }
        else if (_inventory.itemtag == "cestocomlixo")
        {

            for (int i = 0; i < 6; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }

            gameObject.transform.GetChild(6).gameObject.SetActive(true);
            gameObject.transform.GetChild(7).gameObject.SetActive(false);
        }
        else if (_inventory.itemtag == "book")
        {

            for (int i = 0; i < 7; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }

            gameObject.transform.GetChild(7).gameObject.SetActive(true);
        }


    }
    void checkquest()
    {
        if (quests.quests[1] == true &&_inventory.itemtag=="")
        { for (int i = 0; i < 3; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }
              gameObject.transform.GetChild(3).gameObject.SetActive(true);

        }

        else if ((quests.quests[2] == true || (quests.quests[3])) && _inventory.itemtag == "")
        {

            for (int i = 0; i < 5; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }
            gameObject.transform.GetChild(5).gameObject.SetActive(true);
            gameObject.transform.GetChild(7).gameObject.SetActive(true);





        }

    }


}

