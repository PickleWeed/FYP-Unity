using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public static GridManager Instance;

    [SerializeField] private int _width, _height;

    [SerializeField] private Tile _titlePrefab;

    [SerializeField] private Transform _cam;

    private void Awake()
    {
        Instance = this;
    }

    //when Start run GenerateGrid
    private void Start()
    {
        //GenerateGrid();
    }

    public void GenerateGrid()
    {
        for (int x = 0; x < _width-3; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                var spawnedTile = Instantiate(_titlePrefab, new Vector3(x,y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

                //even and odd colouring
                var isOffset = (x + y) % 2 == 1;
                spawnedTile.Init(isOffset);
            }
        }
        //move camera (offset)
        _cam.transform.position = new Vector3((float)_width / 2 - 3.5f, (float)_height / 2 - 0.5f, -10);

        GameManager.Instance.ChangeState(GameState.SpawnNPC);
    }
}
