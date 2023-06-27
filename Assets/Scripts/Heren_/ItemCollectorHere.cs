using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectorHere : MonoBehaviour
{
    private int collectedItems;

    public void CollectItem()
    {
        collectedItems++;
        Debug.Log("Se ha recolectado un item. Total: " + collectedItems);
    }
}
