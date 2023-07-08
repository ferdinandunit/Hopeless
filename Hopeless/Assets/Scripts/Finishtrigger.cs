using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Finishtrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                GameManager.Instance.ChangeScene(SceneManager.GetActiveScene().buildIndex + 1);
                GameManager.Instance.ChangeLevel(GameManager.Instance.levelCurrent + 1);
            }
        }
    }
}
