using UnityEngine;
using System.Collections;

public class AntCollision : MonoBehaviour {

    private float hp = 1;

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Die();
        }
    }

    void OnTriggerEnter2D()
    {
        hp--;
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
