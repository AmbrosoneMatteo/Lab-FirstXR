using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class SerraturaForziere : MonoBehaviour
{
    [SerializeField] private GameObject forziere;
    [SerializeField] private GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag.Equals("key-2")){
            Destroy(other);
            key.gameObject.SetActive(true);
            forziere.GetComponent<XRGrabInteractable>().enabled = true;
        }
    }
}
