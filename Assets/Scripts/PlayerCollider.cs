using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            //Game Over
            Debug.Log("Game Over");

            //maður á helst að geyma reference að Movement componentinu
            GetComponent<Movement>().enabled = false;

            //endum borðið
            FindObjectOfType<Game>().EndGame();
        }
    }
}
