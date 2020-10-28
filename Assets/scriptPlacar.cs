using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scriptPlacar : MonoBehaviour
{
    public int placar = 0;
    public Text txtPlacar;
    public int x = 0;
    public float contagem = 5f;
    public GameObject script;

    public void atualizar(int val)
    {
        placar += val;
        txtPlacar.text = "Placar: " + placar;
        if (placar == 22)
        {
            SceneManager.LoadScene(1);
        } 
    }
    public Text txtPoder;
    public void atualizaPoder(int val)
    {
        if (val == 1)
            x = 1;
        else
            x = 0;
        
    }
    public void Update()
    {
        if(x == 1)
        {
            if(contagem >= 0)
            {
                contagem -= Time.deltaTime;
                txtPoder.text = "Poder: " + (int)contagem;
            }
            else
            {
                x = 0;
                contagem = 5f;
            }
        }
    }
}
