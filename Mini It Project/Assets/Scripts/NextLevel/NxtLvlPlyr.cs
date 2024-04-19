using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour
{
    private Vector3 respawnPoint;

    private void Start()
    {
        respawnPoint = transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag == "NextLevel")
        {
            SceneManager.LoadScene(2);
            respawnPoint = transform.position;
        }
    }
}
