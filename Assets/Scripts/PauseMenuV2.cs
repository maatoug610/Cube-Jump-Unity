using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenuV2 : MonoBehaviour
{
    

    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;
   

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
           
        }
      
        if (isPaused)
        {
            ActivateMenu();
        }
       
        //Resume Game:
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            AudioListener.pause = false;
            pauseMenuUI.SetActive(false);
            isPaused = false;
        }
     
       
        //quit game:
        if (Input.GetKeyDown(KeyCode.Q))
        {
            QuitMenu();
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            Time.timeScale = 1;
            AudioListener.pause = false;
            pauseMenuUI.SetActive(false);
            isPaused = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


    }

    void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
    }

    public void QuitMenu()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    

   

}
