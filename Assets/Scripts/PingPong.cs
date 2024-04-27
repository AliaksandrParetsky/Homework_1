using UnityEngine;

public class PingPong : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 savingPosition;
    private Vector3 endPosition;

    private float speed;

    private void Start()
    {
        speed = 10.0f;

        endPosition = Vector3.zero;

        startPosition = transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPosition, speed * Time.deltaTime);

        if (transform.position == endPosition)
        {
            SwapRoute();
        }
    }

    private void SwapRoute()
    {
        savingPosition = startPosition;
        startPosition = endPosition;
        endPosition = savingPosition;
    }
}
