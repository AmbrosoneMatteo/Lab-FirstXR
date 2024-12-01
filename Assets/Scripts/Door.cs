using System.Collections;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool open = false;
    bool locked = false;
    public void MooveDoor()
    {
        if((!locked))
        {
            locked = true;
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
        locked = false;
    }
}
