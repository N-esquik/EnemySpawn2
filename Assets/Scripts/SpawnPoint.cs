using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _target;

    public void SpawnEnemy()
    {
        _enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
        _enemy.SetDirectionTarget(_target);
    }
}
