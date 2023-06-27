using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController_1 : MonoBehaviour
{
    private int totalScore;

    private void Start()
    {
        PlayerController_1 playerController_1 = FindObjectOfType<PlayerController_1>();

        playerController_1.onPlayerDeath.AddListener(OnPlayerDeath);
        playerController_1.onPlayerScored.AddListener(OnPlayerScored);
    }

    private void OnPlayerDeath()
    {
        string receiverName = System.Reflection.MethodBase.GetCurrentMethod().Name;

        Debug.Log($"{receiverName}: Evento onPlayerDeath recibido. Quién lo llamó: PlayerController");

    }

    private void OnPlayerScored()
    {
        string receiverName = System.Reflection.MethodBase.GetCurrentMethod().Name;

        Debug.Log($"{receiverName}: Evento onPlayerScored recibido. Quién lo llamó: PlayerController");


        totalScore++;
    }
}