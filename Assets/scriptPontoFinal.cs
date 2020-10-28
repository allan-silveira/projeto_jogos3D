using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPontoFinal : MonoBehaviour
{
    // Start is called before the first frame update
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
