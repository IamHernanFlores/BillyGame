using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int hearts = 0;

    [SerializeField] Text heartsText;

    [SerializeField] AudioSource collectionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hearts"))
        {
            Destroy(other.gameObject);
            hearts++;
            heartsText.text = "Hearts: " + hearts;
            collectionSound.Play();

        }
    }
}
