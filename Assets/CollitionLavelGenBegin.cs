using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionLavelGenBegin : MonoBehaviour
{
    [SerializeField] private GameObject backgorundPrefav;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish"){
            Debug.Log("Hit the FInish");
            Instantiate(backgorundPrefav, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, 0), other.transform.rotation);
        }
    }
    
}
