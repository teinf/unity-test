using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform objectToFollow;
    [SerializeField] float speed = 1f;

    void Update()
    {
        if (objectToFollow != null)
        {
            this.transform.position = Vector2.MoveTowards(transform.position, objectToFollow.position, speed * Time.deltaTime);
        }
    }
}
