using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHere : CharacterHere
{
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        Debug.Log("El enemigo ha recibido daño");
    }
}

