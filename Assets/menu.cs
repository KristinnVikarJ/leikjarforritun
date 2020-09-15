using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void LoadGame()
    {
        //loada inn fyrsta levelið
        SceneManager.LoadScene(1);
    }
}
