using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptControlaJogo : MonoBehaviour
{
    private bool pausa = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausa)
            {
                Time.timeScale = 1;
                SceneManager.UnloadSceneAsync(0);
            }
            else
            {
                Time.timeScale = 0;
                SceneManager.LoadScene(0, LoadSceneMode.Additive);
            }
            pausa = !pausa;
        }
    }
}
