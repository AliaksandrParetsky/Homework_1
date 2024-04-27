using System.Collections;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private float time;

    private void Start()
    {
        time = 1.0f;

        StartCoroutine(TeleportPrefab());
    }

    private IEnumerator TeleportPrefab()
    {
        yield return new WaitForSeconds(time);

        transform.position = GetRandomPosition();

        StartCoroutine(TeleportPrefab());
    }

    private Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
    }
}
