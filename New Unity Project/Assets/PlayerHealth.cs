using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int health = 3;
    private Text healthDisplay;
    void Start()
    {
        healthDisplay = GameObject.Find("Health Display").GetComponent<Text>();
    }

    // Update is called once per frame

    public void DamagePlayer(int damage)
    {
        health -= damage;
        healthDisplay.text = "HP: " + health.ToString();
        
    }

    public void updateHealth(int deltaHP)
    {
        health += deltaHP;
        healthDisplay.text = "HP: " + health.ToString();
        
    }
}
