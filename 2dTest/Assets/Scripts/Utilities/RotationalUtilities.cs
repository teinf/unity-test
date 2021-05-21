using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class RotaionalUtilities
{
    public static float GetAngleFromVector(Vector2 vector)
    {
        float radians = Mathf.Atan2(vector.y, vector.x);
        return radians * Mathf.Rad2Deg;
    }

    public static float GetAngleBetweenTwoVectors(Vector2 a, Vector2 b)
    {
        Vector2 direction = b - a;
        return RotaionalUtilities.GetAngleFromVector(direction.normalized);
    }
    public static float GetAngleToMouse(Vector2 position)
    {
        Vector2 mouseWorldPosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return RotaionalUtilities.GetAngleBetweenTwoVectors(position, mouseWorldPosition);
    }

    public static Vector2[] GetShotgunSpread(float angle, int shots, float offsetAngle)
    {
        Vector2[] vectors = new Vector2[shots];

        float angleDifference = angle / (shots * 1f);
        for (int i = 0; i < shots; i += 1)
        {
            float spreadAngle = angleDifference * (i - (shots / 2)) * Mathf.Deg2Rad;
            if (shots % 2 == 0)
            {
                spreadAngle += angleDifference * Mathf.Deg2Rad / 2;
            }
            Vector2 direction = new Vector2();
            direction.x = Mathf.Cos(spreadAngle + offsetAngle * Mathf.Deg2Rad);
            direction.y = Mathf.Sin(spreadAngle + offsetAngle * Mathf.Deg2Rad);

            vectors[i] = direction.normalized;
        }
        return vectors;
    }
}