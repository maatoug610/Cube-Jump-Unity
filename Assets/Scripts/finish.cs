using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;
    // Start is called before the first frame update

  
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Finish")
        {
            isPaused = !isPaused;
        
        }

        if (isPaused)
        {
            ActivateMenu();
        }

    

    }

    void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
    }

}
