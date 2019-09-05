using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUp : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerMovement stats = collision.GetComponent<PlayerMovement>();
            int rand = Random.Range(0, 20);
            stats.PowerUp(rand);
            Destroy(gameObject);
        }
    }
}
