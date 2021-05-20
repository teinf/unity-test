using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerShootsBullets : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    void Start()
    {
        ShootingController shootingController = this.GetComponent<ShootingController>();
        shootingController.OnShootPress += OnPlayerShoot;
    }

    private void OnPlayerShoot(object sender, ShootingController.OnShootPressEventArgs eventArgs)
    {
        GameObject newBullet = Instantiate(bullet, eventArgs.shootingPoint, Quaternion.identity);
        Bullet blt = newBullet.GetComponent<Bullet>();
        Vector2 bltMoveDir = (Vector2)newBullet.transform.position - (Vector2)eventArgs.position;
        blt.Setup(bltMoveDir.normalized);
    }
}
