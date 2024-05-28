using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
//{
//     [SerializeField] private GameObject platformPrefab;
//     [SerializeField] private int startPlatforms;
//     [SerializeField] private float offsetY;
//     [SerializeField] private float rangeX;
//     [SerializeField] private float positionY;

//    private void Start()
//    {
//         for (int i = 0; i < startPlatforms; i++)
//         {
//             SpawnPlatform();
//         }
//    }
//    public void SpawnPlatform()
//     {
//         Vector2 spawnPosition = new Vector2(Random.Range(-rangeX, rangeX), positionY);
//         Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
//         positionY += offsetY;

//     }

//     private void OnTriggerEnter2D(Collider2D collision)
//     {
//         if (collision.CompareTag("Platform"))
//         {
//             SpawnPlatform();
//             Destroy(collision.gameObject);
//         }
//     }
{
    [SerializeField] private GameObject _platformPrefab;
    [SerializeField] private int _startPlatforms;
    [SerializeField] private float _offsetY;
    [SerializeField] private float _rangeX;
    [SerializeField] private float _posY;

    private void Start()
    {
        for (int i = 0; i < _startPlatforms; i++)
        {
            SpawnPlatform();
        }
    }

    public void SpawnPlatform()
    {
        Vector3 spawnPos = new Vector2(Random.Range(-_rangeX,_rangeX),_posY);
        Instantiate(_platformPrefab,spawnPos,Quaternion.identity);
        _posY += _offsetY;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Platform"))
        {
            SpawnPlatform();
            Destroy(collision.gameObject);
        }
    }
}
