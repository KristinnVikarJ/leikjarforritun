using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public Game gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.Win();
    }
}
