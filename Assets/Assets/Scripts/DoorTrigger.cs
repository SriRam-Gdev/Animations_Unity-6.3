using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    // Reference to the Animator component
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("PlayerProximity");
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("PlayerProximity");
    }
}
