using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class LevelControl : MonoBehaviour
{

    public int index;
    public string levelName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(index);

            SceneManager.LoadScene(levelName);
        }
    }
}
