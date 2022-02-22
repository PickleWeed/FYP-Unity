using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;

    [SerializeField] private Tile _titlePrefab;

    [SerializeField] private Transform _cam;

    //when Start run GenerateGrid
    private void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < _width-3; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                var spawnedTile = Instantiate(_titlePrefab, new Vector3(x,y), Quaternion.identity);
                spawnedTile.name = $"Title {x} {y}";

                //even and odd colouring
                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnedTile.Init(isOffset);
            }
        }
        //move camera (offset)
        _cam.transform.position = new Vector3((float)_width / 2 - 3.5f, (float)_height / 2 - 0.5f, -10);
    }
}
