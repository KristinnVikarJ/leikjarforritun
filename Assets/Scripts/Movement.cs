using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Rigidbodyið sem er notað til þess að færa leikmanninn
    private Rigidbody _rb;

    //breyta sem geymir hraðann sem leikmaðurinn getur hreyft sig til hliðar
    public float Speed = 500f;

    //breyta sem geymir hraðann sem leikmaðurinn fer áfram
    public float forwardSpeed = 2000f;

    // Start er keyrt fyrir firsta frameið sem er teiknað í leiknum
    void Start()
    {
        //skulum sækja Rigidbodyið sem er attached við þennan GameObject
        _rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate er keryrt þegar eðlisfræði vélin uppfærir
    void FixedUpdate()
    {
        //færa leikmannin áfram um forwardSpeed
        _rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);

        //ef leikmaðurinn heldur niðri takkanum d á að færa leikmanninn til vinstri
        if (Input.GetKey("a"))
            _rb.AddForce(-Speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        //ef leikmaðurinn heldur niðri takkanum d á að færa leikmanninn til hægri
        if (Input.GetKey("d"))
            _rb.AddForce(Speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
