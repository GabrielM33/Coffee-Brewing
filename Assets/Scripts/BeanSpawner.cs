using UnityEngine;
using System.Collections;

public class BeanSpawner : MonoBehaviour
{
    [SerializeField] private GameObject beanPrefab;
    [SerializeField] private int numberOfBeans; // Number of beans to spawn
    [SerializeField] private GameObject spawn;

    // This function will be called by the Animation Event
    public void ActivateBeanSpawner()
    {
        StartCoroutine(SpawnBeansOverTime());
    }

    IEnumerator SpawnBeansOverTime()
    {
        for (int i = 0; i < numberOfBeans; i++)
        {
            SpawnBean();
            yield return new WaitForSeconds(4f / numberOfBeans); // Wait for the specified time before spawning the next bean
        }
    }

    void SpawnBean()
    {
        var spawnLocation = spawn.transform.position;
        GameObject bean = Instantiate(beanPrefab, spawnLocation, Quaternion.identity);
        Destroy(bean, 20f);
    }
}