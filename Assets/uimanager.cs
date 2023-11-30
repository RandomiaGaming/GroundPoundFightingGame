using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class uimanager : MonoBehaviour {
    public Player player1;
    public Player player2;
    public Text p1;
    public Text p2;
    public Text win;
    public bool winning;
	void Update () {
        if (win.gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("win"))
        {
            winning = true;
        }
        else if(winning)
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        
        p1.text = "Player1 is at " + player1.health + "HP.";
        p2.text = "Player2 is at " + player2.health + "HP.";
        if(player1.health <= 0)
        {
            win.text = "Player2 Wins!";
            
            win.gameObject.GetComponent<Animator>().Play("win");
        }else if (player2.health <= 0)
        {
            
            win.text = "Player1 Wins!";
            win.gameObject.GetComponent<Animator>().Play("win");
        }
    }
}
