using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    private Transform player;
    private Vector2 target;
    public GameObject projectile;
    private Rigidbody2D rb;
    public float thrust = 10f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);

        rb = gameObject.AddComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        Destroy(gameObject, 5);
    }

    public void onCollision(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
            Destroy (other.gameObject);
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject,5);
    }
    
}