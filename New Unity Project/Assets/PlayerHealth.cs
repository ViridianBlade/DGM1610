using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update

    Text healthDisplay;
    public int health = 3;
    void Start()
    {
        healthDisplay = GetComponent<Text>();
    }

    // Update is called once per frame

    public void DamagePlayer(int damage)
    {
        health -= damage;
        healthDisplay.text = "HP: " + health.ToString();
        
    }

    public void HealPlayer(int hpGain)
    {
        health += hpGain;
        healthDisplay.text = "HP: " + health.ToString();
        
    }
}
