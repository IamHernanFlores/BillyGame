using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHere : CharacterHere
{
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        Debug.Log("El jugador ha recibido daño");
    }
}