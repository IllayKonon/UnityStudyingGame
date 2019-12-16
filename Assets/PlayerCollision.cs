using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject menuContainer;
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Enemy")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            menuContainer.SetActive(true);
        }
    }
}
