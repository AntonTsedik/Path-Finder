using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [SerializeField] GameUIManager gameOverManager;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            gameOverManager.SetGameOver();
        }

        if (collision.tag == "Cube")
        {
            Destroy(collision.gameObject);
        }
    }
}
