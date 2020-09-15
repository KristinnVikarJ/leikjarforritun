using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stig : MonoBehaviour
{
    public Transform Player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        //setjum textann sem z staðsetninguna á leikmanninum
        scoreText.text = ((int)Player.position.z).ToString();
    }
}
