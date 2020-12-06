using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Detector : MonoBehaviour, IDragHandler
{
    public Vector2 corner1, corner2;

    private Vector3 origin;

    private void Start()
    {
        origin = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        var plane = new Plane(Vector3.up, transform.position);
        var ray = eventData.pressEventCamera.ScreenPointToRay(eventData.position);

        plane.Raycast(ray, out var distance);
        var newPos = ray.origin + ray.direction * distance;

        newPos.x = Mathf.Clamp(newPos.x, origin.x + corner1.x, origin.x + corner2.x);
        newPos.z = Mathf.Clamp(newPos.z, origin.z + corner1.y, origin.z + corner2.y);

        transform.position = newPos;
    }

    private void OnDrawGizmos()
    {
        var verts = new Vector3[4]
        {
            new Vector3(corner1.x,0,corner1.y),
            new Vector3(corner2.x,0,corner1.y),
            new Vector3(corner1.x,0,corner2.y),
            new Vector3(corner2.x,0,corner2.y)
        };

        var tris = new int[6]
        {
            0, 2, 1,
            2, 3, 1
        };

        var mesh = new Mesh();
        mesh.vertices = verts;
        mesh.triangles = tris;
        mesh.RecalculateNormals();
        
        Gizmos.color = Color.blue;
        Gizmos.DrawMesh(mesh,transform.position);
    }
}
