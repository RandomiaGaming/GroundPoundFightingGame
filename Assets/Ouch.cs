using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ouch : MonoBehaviour {
    public Player player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && collision.gameObject != gameObject)
        {
            player.playerRB.velocity = new Vector2(player.playerRB.velocity.x, player.jumpforce);
            if (player.groundpounding)
            {
                player.groundpounding = false;
                player.hit = true;
                collision.gameObject.GetComponent<Player>().health -= 1;
                Instantiate(player.particals, transform.position, Quaternion.identity);
            }

        }
    }
}
