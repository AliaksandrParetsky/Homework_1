using UnityEngine;

public class Scaler : MonoBehaviour
{
    private float speedScale;

    private Vector3 initialScale;
    private Vector3 finalScale;

    private void Start()
    {
        initialScale = new Vector3(1.0f, 1.0f, 1.0f);
        finalScale = new Vector3(5.0f, 5.0f, 5.0f);
        
        speedScale = 1.0f;

        transform.localScale = initialScale;
    }

    private void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, finalScale, speedScale * Time.deltaTime);
    }
}
