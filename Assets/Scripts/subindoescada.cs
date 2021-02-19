using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subindoescada : MonoBehaviour
{
    public GameObject player;
    public GameObject porta;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
             if (Input.GetKeyDown("z"))
            {
                player.transform.position = porta.transform.position;
            }
        }
    }
}
