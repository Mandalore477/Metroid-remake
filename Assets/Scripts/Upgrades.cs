﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public Samus samus;
    BoxCollider2D bc2D;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        samus = FindObjectOfType<Samus>();
        bc2D = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player") && gameObject.CompareTag("MorphBallUp"))
        {
            samus.canBallMode = true;
            Destroy(this.gameObject);
        }
        if (col.gameObject.CompareTag("Player") && gameObject.CompareTag("RocketsUp"))
        {
            samus.maxRockets += 10;
            samus.rockets += 10;
            Destroy(this.gameObject);
        }
        if (col.gameObject.CompareTag("Player") && gameObject.CompareTag("EnergyUp"))
        {
            samus.maxEnergy += 100;
            samus.energy += 100;
            Destroy(this.gameObject);
        }
        if (col.gameObject.CompareTag("Player") && gameObject.CompareTag("Energy10"))
        {
            samus.energy += 10;
            if(samus.energy> samus.maxEnergy)
            {
                samus.energy = samus.maxEnergy;
            }
            Destroy(this.gameObject);
        }
        if (col.gameObject.CompareTag("Player") && gameObject.CompareTag("Rockets3"))
        {
            samus.rockets += 3;
            if(samus.rockets > samus.maxRockets)
            {
                samus.rockets = samus.maxRockets;
            }
            Destroy(this.gameObject);
        }
        Debug.Log("OnCollisionEnter2D");
    }

    //void OnTriggerEnter2D (Collider2D other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        samus.canBallMode = true;
    //        Destroy(this.gameObject);
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
