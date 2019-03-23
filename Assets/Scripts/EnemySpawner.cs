using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject ObjectPrefab;
    public float SpawnTimer = 10f;
    public UIManager CurrentUIManager;

    private void Start()
    {
        InvokeRepeating("SpawnObject", 0f, SpawnTimer);
    }

    void SpawnObject()
    {
        float objectXPosition = Random.Range(-48, 48);
        float objectZPosition = Random.Range(-7, 45);

        Vector3 calculatedPosition = new Vector3(objectXPosition, transform.position.y, objectZPosition);


        GameObject spawnObject = Instantiate(ObjectPrefab, calculatedPosition, Quaternion.identity);
        spawnObject.GetComponent<Enemy>()?.Init(CurrentUIManager);
    }
}
