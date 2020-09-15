using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    //hefur leikurinn endað?
    bool gameEnded = false;

    //hversu lengi á að bíða áður en borðið byrjar aftur
    public float restartDelay = 2f;

    //reference að ui-inu sem verður teiknað
    public GameObject completeLevelUI;

    public void Win()
    {
        //kveikjum á completeLevelUI
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (!gameEnded)
        {
            //setjum gameEnded sem true
            gameEnded = true;

            //látum unity bíða restartDelay sekundur áður en það keyrir Restart fallið
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        //loadum borðið sem er í gangi nuna
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
