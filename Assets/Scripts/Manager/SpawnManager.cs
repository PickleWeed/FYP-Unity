using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //[SerializeField] private GameObject npc_civilian;

    [SerializeField] private float _width, _height;

    public int numberToSpawn;
    public List<GameObject> spawnPool;

    void Start()
    {
        spawnObject();
    }

    public void spawnObject()
    {
        int randomItem = 0;
        GameObject toSpawn;

        float screenX, screenY;
        Vector2 pos;

        for (int i=0;i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            //offset -3
            screenX = Random.Range((float)0.0000, _width - 3 - 1);
            screenY = Random.Range((float)0.0000, _height - 1);
            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
            
            //add collison
        }
    }
    private void destroyObject()
    {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Spawnable"))
        {
            Destroy(o);
        }
    }

}

// to avoid collision 