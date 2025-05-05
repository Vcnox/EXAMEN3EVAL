using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Arrow : Projectiles
{

    private int direction;


    public Arrow(float damage, float speed, Rigidbody2D _rb2D, Sprite _sprite) : base(damage, speed, _rb2D, _sprite)
    {
        damage = 25f;
        speed = 30f;
       

    }

    public override void Move()
    {
        _rb2D.transform.Translate(Vector2.up * direction * speed * Time.deltaTime);

    }
    public override void Hit(GameObject Arrow)
    {

    }

}
