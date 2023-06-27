using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();

                if (instance == null)
                {
                    GameObject singleton = new GameObject("GameManager");
                    instance = singleton.AddComponent<GameManager>();
                    DontDestroyOnLoad(singleton);
                }
            }

            return instance;
        }
    }

    private int score;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        Debug.Log("Puntuación: " + score);
    }

    public void GameOver()
    {
        Debug.Log("Fin del juego");
    }
}