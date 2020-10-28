using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPonto : MonoBehaviour
{
    public GameObject controlador;
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            GameObject controlador = GameObject.Find("controladorPlacar");
            scriptPlacar script = controlador.GetComponent<scriptPlacar>();
            script.atualizar(1);
            Destroy(this.gameObject);
        }
    }

}
