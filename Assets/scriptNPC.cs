using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptNPC : MonoBehaviour
{
    private NavMeshAgent agente;
    public GameObject pc;
    public GameObject[] waypoints = new GameObject[4];
    private int index = 0;
    private bool perseguicao = false;
    public float maxDistAlvo = 30;
    public float maxDist = 2;
    public bool x = false;
    public float contagem = 10f;
    public Slider vida;
    public float vidaMx = 100.0f;
    public bool mata = false;
    public GameObject script;
    public int bate;
    // Start is called before the first frame update
    void Start()
    {
        vida.minValue = 0;
        vida.maxValue = vidaMx;
        vida.value = vidaMx;
        agente = GetComponent<NavMeshAgent>();
        proximo();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (x == true && col.tag == "Player")
        {
            Destroy(this.gameObject);          
        }
        else if (col.tag == "Player" && x == false)
        {
            vida.value = vida.value - 33.4f;
            if(vida.value <= 0)
            {
                Destroy(col.gameObject);
                SceneManager.LoadScene(2);
            }
        }
    }
    
    private void proximo()
    {
        agente.SetDestination(waypoints[index++].transform.position);
        if (index >= waypoints.Length)
            index = 0;
        
    }
    // Update is called once per frame
    void Update()
    {
        if(perseguicao || Vector3.Distance(transform.position, pc.transform.position) <= maxDistAlvo)
        {
            perseguicao = true;
            agente.SetDestination(pc.transform.position);
        }else if (Vector3.Distance(transform.position, agente.destination) < maxDist)
            proximo();
        
        if (vida.value >= vidaMx)
        {
            vida.value = vidaMx;
        }
        if (vida.value <= vida.minValue)
        {
            vida.value = vida.minValue;
        }

        bate = script.GetComponent<scriptPC>().bate;

        if (bate == 1)
            x = true;
        else
            x = false;
    }
}
