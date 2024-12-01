using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerbutton : MonoBehaviour
{
    [SerializeField] private GameObject door;
    public bool powered = false;
    // Start is called before the first frame update
    void Start()
    {
        if(!powered)
        {
            powered = true;
        }
        turnOn(); 
    }

    public void turnOn()
    {
        if (!powered)
        {
            GetComponent<MeshRenderer>().materials[1].color = Color.green;
            powered = true;
        }
        else
        {
            GetComponent<MeshRenderer>().materials[1].color = Color.red;
            powered = false;
        }
        door.GetComponent<keydoor>().powered = this.powered;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
