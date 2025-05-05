using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Projectiles
{
    public Arrow(float damage, float speed, Rigidbody2D _rb2D, Sprite _sprite) : base(damage, speed, _rb2D, _sprite)
    {
        damage = 25f;
        speed = 30f;
    }

    public override void Move()
    {
        
    }
}
