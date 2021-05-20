using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootingPoint;

    public float delay = 0.5f;
    float timeBetweenSpawn = 0;

    private void Start() {

        float timeBetweenSpawn = delay;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (timeBetweenSpawn <= 0) {
                GameObject newBullet = Instantiate(bullet, shootingPoint.position, Quaternion.identity);
                Bullet blt = newBullet.GetComponent<Bullet>();
                Vector2 bltMoveDir = (Vector2)newBullet.transform.position - (Vector2)transform.position;
                blt.Setup(bltMoveDir.normalized);
                timeBetweenSpawn = delay;
            }
            timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
