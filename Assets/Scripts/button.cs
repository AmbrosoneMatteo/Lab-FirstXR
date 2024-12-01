using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public void OpenColor()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        if (mr.materials[1].color.Equals(Color.red))
        {
            mr.materials[1].color = Color.green;
        }
        else
        {
            mr.materials[1].color = Color.red;
        }
    }
}
