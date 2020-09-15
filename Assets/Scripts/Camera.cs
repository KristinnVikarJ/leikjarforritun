using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //leikmaðurinn
    public Transform Player;

    //hvar á myndavélin að vera miðað við leikmanninn
    public Vector3 Offset;

    // Keyrt einu sinni á frame
    void Update()
    {
        //setjum staðsetninguna á myndavélini á leikmanns staðsetning + offset
        transform.position = Player.position + Offset;
    }
}
