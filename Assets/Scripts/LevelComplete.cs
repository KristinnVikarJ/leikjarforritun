using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        //förum yfir á næsta borð
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
