using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KassieGameManager : MonoBehaviour
{
    public GameObject platformPrefab;

    public int platformCCount = 300;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCCount; i++)
        {
            spawnPosition.y += Random.Range(.5f, 2f);
            spawnPosition.x = Random.Range(-5f, 5f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
