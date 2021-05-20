using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FollowObject : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow;
    [SerializeField] float speed = 1f;

    Rigidbody2D rigidbody2d;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float realSpeed = speed * Time.deltaTime;
        Vector2 direction = (objectToFollow.transform.position - transform.position).normalized;
        rigidbody2d.velocity = direction * realSpeed;
    }
}
