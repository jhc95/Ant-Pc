using UnityEngine;
using System.Collections;

public class DropCollision : MonoBehaviour {

    private float hp = 1;
    public GameObject DeathPrefab;

    // Use this for initialization
    void Update()
    {
        if (hp <= 0)
        {
            Die();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Platform" || col.gameObject.tag == "Player")
        {
            hp--;
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Instantiate(DeathPrefab, transform.position, Quaternion.identity);
    }
}
