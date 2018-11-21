using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject RainDropPrefab;
    private float rate = 1;
    private float nextRain = 1;
    private float spawnDis = 5.4f;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        nextRain -= Time.deltaTime;
        if (nextRain <= 0)
        {
            nextRain = rate;
            rate *= 1f;
            Vector3 offset = new Vector3(Random.Range(-20, 20) * 0.15f, Random.Range(4,20) * 0.5f,0);
            offset.z = 0;
            offset = offset.normalized * spawnDis;
            Instantiate(RainDropPrefab, transform.position + offset, Quaternion.identity);
        }
    }
}
