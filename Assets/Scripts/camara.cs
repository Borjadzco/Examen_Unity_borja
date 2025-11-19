using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform target;

    public void LateUpdate()
    {
        target.position = new Vector3(target.position.x, target.position.y, -10f);
    }
}
