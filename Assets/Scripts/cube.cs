using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    CharacterController controller;

    public float speed = 6f;
    public float gravity = 20f;
    public float jump = 8f;

    bool isleft;
    bool isright;
  
    public GameObject player;
    Vector3 movedirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        movedirection.y -= gravity * Time.deltaTime;
        controller.Move(movedirection * Time.deltaTime);

        if (controller.isGrounded)
        {
            movedirection = new Vector3(Input.GetAxis("Horizontal"), 0f, 3);
            movedirection *= speed;

            if (isleft)
            {
                player.transform.Translate(-0.2f, 0, 0);
            }
            if (isright)
            {
                player.transform.Translate(0.2f, 0, 0);
            }
           
        }
        
    }


    //toLeft:
    public void PointerDownLeft()
    {
        isleft = true;
    }
    public void PointerUpLeft()
    {
        isleft = false;
    }

    //toRight:
    public void PointerDownRight()
    {
        isright = true;
    }
    public void PointerUpRight()
    {
        isright = false;
    }

    //isJumping
    public void Jump()
    {
        if (controller.isGrounded)
        {
            movedirection.y = jump;
        }
    }

  
}
