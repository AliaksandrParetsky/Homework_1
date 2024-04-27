using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 angle;

    private void Start()
    {
        angle.x = 1.0f;
    }

    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(angle);
    }
}
