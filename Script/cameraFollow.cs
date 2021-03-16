using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset = new Vector3(0,0,-2);

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
