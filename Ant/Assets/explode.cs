using UnityEngine;
using System.Collections;

public class explode : MonoBehaviour {

    private float deathTime = 0.3f;
    void Awake()
    {
        Destroy(gameObject, deathTime);
    }
}
