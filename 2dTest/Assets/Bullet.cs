using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    float speed = 0f;
    float lifeTime = 10f;
    Vector2 moveDir = new Vector2();
    Rigidbody2D rb;
    public SpriteRenderer sr;
    public void Setup(Vector2 moveDirection)
    {
        this.moveDir = moveDirection;
        float angle = RotaionalUtilities.GetAngleFromVector(moveDir);
        this.transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public void Setup(float angle)
    {
        this.transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        SetRandomColor();
    }

    void Update()
    {
        rb.MovePosition(rb.position + moveDir * Time.deltaTime * this.speed);
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        //TODO: Spawn Bullet Destroy Effect
        Object.Destroy(gameObject);
    }

    public void SetRandomColor()
    {
        float r = Random.Range(0, 255) / 255.0f;
        float g = Random.Range(0, 255) / 255.0f;
        float b = Random.Range(0, 255) / 255.0f;

        sr.color = new Color(r, g, b);
    }

}
