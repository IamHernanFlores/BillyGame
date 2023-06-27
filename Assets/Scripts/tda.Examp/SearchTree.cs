using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchTree : MonoBehaviour
{
    private BinarySearchTree<int> binarySearchTree;

    private void Start()
    {
        binarySearchTree = new BinarySearchTree<int>();

        binarySearchTree.Insert(10);
        binarySearchTree.Insert(5);
        binarySearchTree.Insert(15);
        binarySearchTree.Insert(2);
        binarySearchTree.Insert(7);

        Debug.Log("Elementos del árbol binario de búsqueda (en orden ascendente):");

        binarySearchTree.TraverseInOrder();
    }
}