using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptportal2 : MonoBehaviour
{
    public GameObject pc;
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            pc.transform.position = new Vector3(-24.6f, 0.37f, -22.3f);
        }

    }
}
