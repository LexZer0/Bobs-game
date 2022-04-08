using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int DoorIsOpen()
    {
        Debug.Log("Door is Worked!!!!");
        anim.Play("Door");
        return 0;
    }
}
