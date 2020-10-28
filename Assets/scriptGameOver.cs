using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scriptGameOver : MonoBehaviour
{    public void Start()
    {
        Cursor.visible = true;
    }
    // Start is called before the first frame update
    public void iniciar()
    {
        SceneManager.LoadScene(1);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
