using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkList : MonoBehaviour
{
    private LinkedList<string> linkedList;

    private void Start()
    {
        linkedList = new LinkedList<string>();

        linkedList.AddLast("Elemnt1");
        linkedList.AddLast("Elemnt2");
        linkedList.AddLast("Elemnt3");

        Debug.Log("Elementos de la lista enlazada:");

        foreach (var element in linkedList)
        {
            Debug.Log(element);
        }
    }
}