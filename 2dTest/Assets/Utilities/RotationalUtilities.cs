using UnityEngine;
using System.Collections;
using System.Collections.Generic;
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
}