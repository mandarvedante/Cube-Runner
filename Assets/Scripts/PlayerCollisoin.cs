using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;
    public Score scoreScript;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audioSource1;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle")) 
        {
            audioSource1.Play();
            gameController.GameOver();
            if (scoreScript != null) 
            {
                scoreScript.GameOver(); 
            }
            Destroy(gameObject); 
        }
    }
}
