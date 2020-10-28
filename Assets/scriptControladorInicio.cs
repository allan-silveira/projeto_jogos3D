using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scriptControladorInicio : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        Cursor.visible = true;
    }
    public void iniciar()
    {
        SceneManager.LoadScene(1);
    }
    public void sair()
    {
        Application.Quit();
    }
}
