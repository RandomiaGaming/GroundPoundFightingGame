using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float jumpforce;
    public float moveforce;
    public Groundchecker groundchecker;
    public string button;
    public string gpbutton;
    public string axis;
    public int health = 5;
    public bool groundpounding;
    public GameObject particals;
    public bool hit = false;
    void Update()
    {

        if (groundchecker.onground)
        {
            hit = false;
            groundpounding = false;
        }
        if(Input.GetButtonDown(gpbutton) == true && hit == false)
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, -jumpforce);
            groundpounding = true;
        }
        if (Input.GetButtonDown(button) == true)
        {
            if (groundchecker.onground == true)
            {
                playerRB.velocity = new Vector2(playerRB.velocity.x, jumpforce);
            }
        }
        if (!groundpounding)
        {
            playerRB.velocity = new Vector2(moveforce * Input.GetAxisRaw(axis), playerRB.velocity.y);
        }
        else
        {
            playerRB.velocity = new Vector2(0, playerRB.velocity.y);
        }
    }
    
}
