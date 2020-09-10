using UnityEngine;

public class Rooms : MonoBehaviour
{
    public ConnectPoints[] connectPoints;
    public MeshCollider meshCollider;

    public Bounds AreaLimit
    {
        get
        {
            return meshCollider.bounds;
        }
    }
}
