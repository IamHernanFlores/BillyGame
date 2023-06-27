using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController_1 : MonoBehaviour
{
    public UnityEvent onPlayerDeath;
    public UnityEvent onPlayerScored;

    public bool isDead;
    public int score;

    private void Update()
    {
     
        if (!isDead && HasPlayerDied())
        {
            string callerName = System.Reflection.MethodBase.GetCurrentMethod().Name;

            onPlayerDeath.Invoke();

            Debug.Log($"{callerName}: Evento onPlayerDeath invocado. Quienes lo recibieron: {onPlayerDeath.GetPersistentEventCount()}");

            isDead = true;
        }

        if (!isDead && HasPlayerScored())
        {
            string callerName = System.Reflection.MethodBase.GetCurrentMethod().Name;

            onPlayerScored.Invoke();

            Debug.Log($"{callerName}: Evento onPlayerScored invocado. Quienes lo recibieron: {onPlayerScored.GetPersistentEventCount()}");

            score++;
        }
    }

    private bool HasPlayerDied()
    {
        if (transform.position.y < -10f)
        {
            return true;
        }

        return false;
    }

    private bool HasPlayerScored()
    {

        Collider[] colliders = Physics.OverlapSphere(transform.position, 1f);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Score"))
            {
                return true;
            }
        }

        return false;
    }
}