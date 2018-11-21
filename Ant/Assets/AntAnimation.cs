using UnityEngine;
using System.Collections;

public class AntAnimation : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("MoveLeft", false);
            anim.SetBool("Right", true);
            anim.SetBool("Left", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            anim.SetBool("MoveRight", false);
            anim.SetBool("Right", false);
            anim.SetBool("Left", true);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("MoveRight", true);
        }
        else {
            anim.SetBool("MoveRight", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            anim.SetBool("MoveLeft", true);
        }
        else {
            anim.SetBool("MoveLeft", false);
        }
    }
}
