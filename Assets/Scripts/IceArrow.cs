using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class IceArrow : Projectiles
{
     
    
    public override void Move()
    {
      
    }
    public IceArrow(float damage, float speed, Rigidbody2D _rb2D, Sprite _sprite) : base(damage, speed, _rb2D, _sprite)
    {
        damage = 10f;
        speed = 15f;
        

    }

    


   
}
