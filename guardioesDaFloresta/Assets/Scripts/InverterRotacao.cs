using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InverterRotacao : MonoBehaviour
{
    Quaternion rotation;
    void Awake()
    {
        rotation = transform.rotation;
    }
    void LateUpdate()
    {
        transform.rotation = rotation;
    }
}
