using System;
using UnityEngine;


[RequireComponent(typeof(Camera))]
public class SetAsCamera3D : MonoBehaviour
{
    private void Start()
    {
        Utils.Camera3D = GetComponent<Camera>();
    }
}