using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private bool _isBugSpawned = false;
    [SerializeField]
    private GameObject _spawner;
    [SerializeField]
    private float _timeBetweenSpawns = 1f;
    [SerializeField]
    private GameObject[] Bugs;

    private GameObject _currentBug;

    private void SpawnObjects()
    {

    }

    private void DespawnObjects()
    {

    }
}
