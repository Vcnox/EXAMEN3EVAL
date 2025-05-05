using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : Projectiles
{
    private float Distance = 3f;
    private Vector3 InicalPosition;
    private int Direction = 1;


    void Start()
    {
        _rb2D.transform.position = InicalPosition;
    }

    public Boomerang(float damage, float speed, Rigidbody2D _rb2D, Sprite _sprite) : base(damage, speed, _rb2D, _sprite)
    {
        damage = 8f;
        speed = 10f;

    }

    public override void Move()
    {
        _rb2D.transform.Translate(Vector2.up * Direction * speed * Time.deltaTime); 
        if(Mathf.Abs(_rb2D.transform.position.x - InicalPosition.x) >= Distance)
        {
            Direction = -1;
        }
    }
    public override void Hit(GameObject Boomerang)
    {

    }

}
