using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInstances : MonoBehaviour
{
    public GameObject player;
    public static GlobalInstances Instance { get; private set; }
    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }
    }
}
