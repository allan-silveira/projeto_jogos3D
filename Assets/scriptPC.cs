using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class scriptPC : MonoBehaviour
{
    private Rigidbody rbd;
    public float velocidade = 5;
    public float velRot = 100;
    private Quaternion rotOriginal;
    private float rotMouseX = 0;
    private float rotTecladoX = 0;
    public GameObject poder;
    public int teste = 0;
    public float contagem = 5f;
    public int bate = 0;
    private AudioSource som;
    // Start is called before the first frame update

    void Start()
    {
        som = GetComponent<AudioSource>();
        rbd = GetComponent<Rigidbody>();
        rotOriginal = transform.localRotation;
        Cursor.visible = false;
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "poder")
        {
            GameObject controlador = GameObject.Find("controladorPlacar");
            scriptPlacar script = controlador.GetComponent<scriptPlacar>();
            teste = 1;
            script.atualizaPoder(1);
            Destroy(col.gameObject);
            som.Play();
        }

    }

    private void para()
    {
        som.Stop();
    }
    // Update is called once per frame
    void Update()
    { 
        float moveFrente = Input.GetAxis("Vertical");
        float moveLado = Input.GetAxis("Horizontal");

        Vector3 vel = transform.TransformDirection(moveLado * velocidade, rbd.velocity.y, moveFrente * velocidade);

        rbd.velocity = vel;
   
        //rotaciona
        rotMouseX += Input.GetAxis("Mouse X");
        if (Input.GetKey(KeyCode.Q))
            rotTecladoX -= 1;
        else if (Input.GetKey(KeyCode.E))
            rotTecladoX += 1;

        Quaternion lado = Quaternion.AngleAxis(rotMouseX + rotTecladoX, Vector3.up);
        
        transform.localRotation = rotOriginal * lado;
        if (teste == 1)
        {
            if (contagem >= 0)
            {
                bate = 1;
                teste = 1;
                contagem -= Time.deltaTime;
            }
            else
            {
                bate = 0;
                teste = 0;
                contagem = 5f;
                som.Stop();
            }
        }
        
    }
}
