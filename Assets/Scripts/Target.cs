using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed = 5f;

    private int _currentWaypoints = 0;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if(transform.position == _waypoints[_currentWaypoints].position)
        {
            _currentWaypoints = (_currentWaypoints + 1) % _waypoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoints].position, _speed * Time.deltaTime);
    }
}
