using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManager : GameManager
{
    // Start is called before the first frame update
    void Start()
    {
        SpawnEntity();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void SpawnEntity()
    {
        float startDelay = 3.0f;
        float repeatRateMin = 4.5f;
        float repeatRateMax = 8.0f;
        InvokeRepeating("SpawnShip", startDelay, Random.Range(repeatRateMin,repeatRateMax));
    }

    void SpawnShip()
    {
        float waterLevel = 3.7f;
        Vector2 spawnPos = new Vector2(14, Random.Range((waterLevel - 0.5f), waterLevel));
        int horizontalIndex = Random.Range(0, LevelPrefabs.Length);
        Instantiate(LevelPrefabs[horizontalIndex], spawnPos, LevelPrefabs[horizontalIndex].transform.rotation);
    }
}