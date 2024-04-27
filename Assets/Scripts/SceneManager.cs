using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private GameObject instance;

    [SerializeField] private List<GameObject> prefabs = new();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int index = 0; index < prefabs.Count; index++)
            {
                if (prefabs[index] == null)
                {
                    Debug.LogError($"Prefab under index number {index} is NULL!");
                    return;
                }
            }

            if (instance != null)
            {
                Destroy(instance);
            }

            CreatePrefab();
        }
    }

    private GameObject GetRandomPrefab()
    {
        var randomIndex = Random.Range(0, prefabs.Count);

        return prefabs[randomIndex];
    }

    private void CreatePrefab()
    {
        var rotation = Quaternion.identity;
        var position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));

        instance = Instantiate(GetRandomPrefab(), position, rotation);

        Debug.Log($"A prefab {instance.name} was created");
    }
}
