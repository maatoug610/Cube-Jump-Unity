using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public float threshold= 0;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            Debug.Log("end");
            // Application.Quit();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player")
            {
          
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    
    }
}
