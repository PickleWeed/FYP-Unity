using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //[SerializeField] private GameObject npc_civilian;

    public static SpawnManager Instance;

    [SerializeField] private float _width, _height;

    public int numberToSpawn;
    public List<GameObject> spawnPool;

    public List<ScriptableNPC> _npcs;

    private float checkRadius = 0.09f;

    

    private void Awake()
    {
        Instance = this;

       // _npcs = Resources.LoadAll<ScriptableNPC>("NPCS").ToList();
    }

    void Start()
    {
        //spawnObject();
    }
    public void spawnObject()
    {
        //destroyObject();
        //int randomItem = 0;
        GameObject toSpawn;

        float screenX, screenY;
        Vector2 pos;
        int redNPCSpawnThreshold = numberToSpawn / 10;

        for (int i = 0; i < numberToSpawn; i++)
        {
            //randomItem = Random.Range(0, spawnPool.Count);
            //toSpawn = spawnPool[randomItem];
            if (redNPCSpawnThreshold > 0){
                redNPCSpawnThreshold--;
                toSpawn = spawnPool[1];
            }
            else
                toSpawn = spawnPool[0];

            //offset -3 to move to the right
            screenX = Random.Range((float)0.0000, _width - 3 - 1);
            screenY = Random.Range((float)0.0000, _height - 1);
            pos = new Vector2(screenX, screenY);

            //add collison
            Collider2D Collision = Physics2D.OverlapCircle(pos, checkRadius, LayerMask.GetMask("NPC"));
            if (Collision == false) {
                Instantiate(toSpawn, pos, toSpawn.transform.rotation);
            }
        }
        //GameManager.Instance.ChangeState(GameState.SpawnRedNPC);
    }
    /*private void destroyObject()
    {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("GreyNPC"))
        {
            Destroy(o);
        }
    }*/
}

// to avoid collision 