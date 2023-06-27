using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    protected bool isDead = false;
    protected AudioSource deathSound;

    protected virtual void Die()
    {
        isDead = true;
        deathSound.Play();
    }

    internal void Attack()
    {
        throw new NotImplementedException();
    }
}

public class Player : Character
{
    private void Update()
    {
        if (transform.position.y < -1f && !isDead)
        {
            Die();
            Invoke(nameof(ReloadLevel), 1.3f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Die();
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
            Invoke(nameof(ReloadLevel), 1.3f);
        }
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

public class Enemy : Character
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Die();
            Destroy(gameObject);
        }
    }
}