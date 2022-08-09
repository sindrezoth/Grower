using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject FishPrefab;

    void Start()
    {
        StartCoroutine(CoroutineSpawner());

    }

    IEnumerator CoroutineSpawner()
    {
        do
        {
            yield return new WaitForSeconds(1f);

            float y = Random.Range(-5f, 5f);
            Vector3 pos = transform.position + new Vector3(0, y, 0);
            GameObject.Instantiate(FishPrefab, pos, transform.rotation);
        }while(true);
    }

}
