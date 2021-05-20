using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    void Update()
    {
        float angle = RotaionalUtilities.GetAngleToMouse(transform.position);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
