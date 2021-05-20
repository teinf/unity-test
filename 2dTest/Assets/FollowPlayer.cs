using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Player player;
    [SerializeField] float speed = 1f;

    Rigidbody2D rigidbody2d;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<Player>();
    }

    void FixedUpdate()
    {
        if (player == null)
        {
            rigidbody2d.velocity = Vector2.zero;
            return;
        }

        float realSpeed = speed * Time.deltaTime;
        Vector2 direction = (player.transform.position - transform.position).normalized;
        rigidbody2d.velocity = direction * realSpeed;
    }
}
