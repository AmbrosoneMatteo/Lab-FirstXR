using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.InputSystem;

public class keydoor : MonoBehaviour
{
    public bool powered = false;
    private bool open = false;
    private bool mooving = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MooveDoor()
    {
        if((!mooving)&&(powered))
        {
            mooving = true;
            StartCoroutine(moove());
        }
    }
    IEnumerator moove()
    {
        float baseY = transform.transform.position.y;
        float count = 0.0f;
        float direction = 1f;
        if (open)
        {
            open = false;
            direction = -1f;
        }
        else
        {
            open = true;
        }
        while (count < 2.0f)
        {
            count += 0.5f * Time.deltaTime;
            yield return new WaitForSeconds(0.01f);
            transform.position = new Vector3(transform.position.x, baseY + count * direction, transform.position.z);
        }
        mooving = false;
    }
}
