using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] private GameObject groundPrefab;
    [SerializeField] private int numberOfgrounds;
    [SerializeField] private GameObject spawn;

    private List<GameObject> beanPool;

    private void Start()
    {
        beanPool = new List<GameObject>();
        for (int i = 0; i < numberOfgrounds; i++)
        {
            GameObject bean = Instantiate(groundPrefab);
            bean.SetActive(false);
            beanPool.Add(bean);
        }
    }

    // This function will be called by the Animation Event
    public void ActivateBeanSpawner()
    {
        StartCoroutine(SpawnBeansOverTime());
    }

    IEnumerator SpawnBeansOverTime()
    {
        float waitTime = 4f / numberOfgrounds;
        for (int i = 0; i < numberOfgrounds; i++)
        {
            SpawnBean();
        }
        yield return new WaitForSeconds(waitTime);
    }

    void SpawnBean()
    {
        foreach (GameObject bean in beanPool)
        {
            if (!bean.activeInHierarchy)
            {
                bean.transform.position = spawn.transform.position;
                bean.SetActive(true);
                return;
            }
        }
    }
}