using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(4f, 1f, -10f);

    void LateUpdate()
    {
        if (target == null) return;

        transform.position = new Vector3(
            target.position.x + offset.x,
            target.position.y + offset.y,
            offset.z
        );
    }
}