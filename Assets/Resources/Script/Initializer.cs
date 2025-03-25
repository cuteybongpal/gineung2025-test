using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    public static bool isInitialized = false;
    public void Awake()
    {
        if (isInitialized)
            return;
        DataManager.Instance.Init();
        isInitialized = true;
    }
}
