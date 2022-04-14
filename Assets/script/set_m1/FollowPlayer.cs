using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class FollowPlayer : MonoBehaviour
{
    [SerializeField] float _speed = 1f;
    Transform _target = default;

    void Update()
    {
        if (_target)
        {
            Vector3 dir = _target.position - this.transform.position;
            this.transform.Translate(dir.normalized * _speed * Time.deltaTime);
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _target = collision.gameObject.transform;
        }
    }
}