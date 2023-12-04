using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2;
    private float repeatRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle() {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);}

    // Update is called once per frame
    void Update()
    {
        
    }
}
