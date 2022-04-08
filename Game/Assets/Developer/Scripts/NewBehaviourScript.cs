using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    GameObject gameObject;
       void Start()
    {
        gameObject = GameObject.Find("Door");
    }

    // Update is called once per frame
    void Update()
    {
         }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {

            gameObject.GetComponent<DoorAnim>().DoorIsOpen();

        }
    }
}
