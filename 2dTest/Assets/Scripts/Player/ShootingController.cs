using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public Transform shootingPoint;

    public float delay = 0.5f;
    float shootingCooldown = 0;
    public event EventHandler<OnShootPressEventArgs> OnShootPress;
    public class OnShootPressEventArgs : EventArgs
    {
        public Vector2 position;
        public Vector2 shootingAt;
        public Vector2 shootingPoint;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (shootingCooldown <= 0)
            {
                OnShootPress?.Invoke(this, new OnShootPressEventArgs
                {
                    position = transform.position,
                    shootingAt = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition),
                    shootingPoint = shootingPoint.position
                });
                shootingCooldown = delay;
            }
            shootingCooldown -= Time.deltaTime;
        }
    }
}
