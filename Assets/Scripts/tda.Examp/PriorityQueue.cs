using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriorityQueue : MonoBehaviour
{
    private PriorityQueue<int> priorityQueue;

    private void Start()
    {
        priorityQueue = new PriorityQueue<int>();

        priorityQueue.Enqueue(3, 3);
        priorityQueue.Enqueue(1, 1);
        priorityQueue.Enqueue(2, 2);

        Debug.Log("Elementos de la cola de prioridad (en orden de prioridad descendente):");

        while (!priorityQueue.IsEmpty())
        {
            int element = priorityQueue.Dequeue();
            Debug.Log(element);
        }
    }
}