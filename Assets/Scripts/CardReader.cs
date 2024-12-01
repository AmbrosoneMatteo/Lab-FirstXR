using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardReader : MonoBehaviour
{
    public GameObject door;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag.Equals("key-1"))
        {
            if(door.GetComponent<keydoor>().powered) {
                door.GetComponent<keydoor>().MooveDoor();
                GetComponent<MeshRenderer>().material.color = Color.green;
            }
        }
    }
}
