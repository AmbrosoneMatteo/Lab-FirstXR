using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public void changeColorOnGrab()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    public void changeColorOnLoose()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }

}
