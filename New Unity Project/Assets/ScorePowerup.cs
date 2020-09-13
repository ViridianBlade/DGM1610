using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePowerup : MonoBehaviour
{
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("Player1");
    }
    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<PlayerScore>().updateScore(1);
    }
}
