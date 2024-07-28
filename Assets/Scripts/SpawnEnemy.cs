using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;

    private float _spawnTime = 0;
    private float _spawnDelay = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), _spawnTime, _spawnDelay);
    }

    private void Spawn()
    {
        SpawnPoint spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
        spawnPoint.SpawnEnemy();
    }
}
