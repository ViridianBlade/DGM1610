using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpOrb : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int healAmount = 1;
    private void OnTriggerEnter(Collider other)
    {
        playerHealth.HealPlayer(healAmount);
    }
}
