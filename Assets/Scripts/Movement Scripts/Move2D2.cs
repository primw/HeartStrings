using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D2 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isGrounded = false;
    private Animator animator;

    public GameObject bone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal1"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump1") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 16f), ForceMode2D.Impulse);
        }
    }
}
