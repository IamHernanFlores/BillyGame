using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterHere : MonoBehaviour
{
    protected int health;
    public UnityEvent onJump;
    public UnityEvent onAttack;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        Debug.Log("Personaje saltando");
        onJump.Invoke();
        // Realiza acciones adicionales al saltar
    }

    private void Attack()
    {
        Debug.Log("Personaje atacando");
        onAttack.Invoke();

    }

    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Salud restante: " + health);
    }
   
    
}
    
