using UnityEngine;
using System.Collections;

public class AntMovement : MonoBehaviour {

    public float maxspeed;
    private Rigidbody2D rb;
    public Animator anim;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(maxspeed, rb.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
            anim.SetInteger("Walk", 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-maxspeed, rb.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
            anim.SetInteger("Walk", 1);
        }
        else {
            rb.velocity = new Vector2(0, rb.velocity.y);
            anim.SetInteger("Walk", 0);
        }
    }
}
