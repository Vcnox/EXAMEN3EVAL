using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using JetBrains.Annotations;
using UnityEngine;

public class IceArrow : Projectiles
{
     public float xSpeed, ySpeed;   
    
    public override void Move()
    {
    _rb2D.transform.Translate(new Vector2(xSpeed, Mathf.Sin(Time.time) * ySpeed) * Time.deltaTime);
    }
    public IceArrow(float damage, float speed, Rigidbody2D _rb2D, Sprite _sprite) : base(damage, speed, _rb2D, _sprite)
    {
        damage = 10f;
        speed = 15f;
        

    }

    public override void Hit(GameObject IceArrow)
    {
        
    }

}
