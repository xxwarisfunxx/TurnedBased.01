using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectPoints : MonoBehaviour
{
    void OnDrawGizmos()
    {
        Ray ray = new Ray(transform.position, transform.rotation * Vector3.forward);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(ray);
    }
}
