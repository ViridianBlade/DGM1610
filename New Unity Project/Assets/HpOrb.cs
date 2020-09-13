using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpOrb : MonoBehaviour
{
    private PlayerHealth playerHP;
    public int healAmount = 1;

    void Start()
    {
        playerHP = GameObject.Find("Player1").GetComponent<PlayerHealth>();
    }
    private void OnTriggerEnter(Collider other)
    {
        playerHP.updateHealth(healAmount);
    }
}
