using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPortal : MonoBehaviour
{
    public GameObject pc;
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            pc.transform.position = new Vector3(-31, 0.37f, -14.48f);
        }

    }

}
