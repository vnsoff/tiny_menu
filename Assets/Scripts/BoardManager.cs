using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public int width;
    public int height;
    public GameObject[] piecesPrefabs; 
    public Transform spawnPoint;

    private void Start()
    {
        GenerateBoard();
    }

    void GenerateBoard()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector2 spawnPosition = spawnPoint.position + new Vector3(x, y, 0);
                int pieceIndex = Random.Range(0, piecesPrefabs.Length);
                GameObject candy = Instantiate(piecesPrefabs[pieceIndex], spawnPosition, Quaternion.identity);
                candy.transform.parent = transform;
            }
        }
    }
}
