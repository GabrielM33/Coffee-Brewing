using UnityEngine;

public class BeanSpawner : MonoBehaviour
{
    public GameObject beanPrefab; // Assign your bean prefab in the inspector
    //public Vector3 centerPosition; // Center position of the spawning area
    public int numberOfBeans = 200; // Number of beans to spawn
    public float spawnAreaSize = 0.05f; // Size of the spawn area in meters (5 cm)

    void OnEnable()
    {
        for (int i = 0; i < numberOfBeans; i++)
        {
            SpawnBean();
        }
    }

    void SpawnBean()
    {
        Vector3 spawnPosition = transform.localPosition + new Vector3(
            (Random.value - 0.5f) * spawnAreaSize,
            (Random.value - 0.5f) * spawnAreaSize,
            (Random.value - 0.5f) * spawnAreaSize
        );

        Instantiate(beanPrefab, spawnPosition, Quaternion.identity);
    }
}