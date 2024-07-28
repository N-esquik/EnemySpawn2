using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    private Transform _target;

    private float _stopDistanceTarget = 5f;

    private void Update()
    {
        Move();
    }

    public void SetDirectionTarget(Transform target)
    {
        _target = target;
    }

    private void Move()
    {
        Vector3 direction = _target.position - transform.position;

        float distance = direction.magnitude;

        if (distance > _stopDistanceTarget) 
        {
            direction.Normalize();

            Quaternion quaternion = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, quaternion, Time.deltaTime);

            transform.Translate(direction * _speed * Time.deltaTime,Space.World);
        }
    }
}
