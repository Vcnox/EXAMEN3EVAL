using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum ProjectileType { ICEARROW, ARROW, BOOMERANG }

public abstract class Projectiles
{
    protected float speed;
    protected float damage;
    protected Rigidbody2D _rb2D;
    private Sprite _sprite;


    public Projectiles(float damage, float speed, Rigidbody2D _rb2D, Sprite _sprite)
    {

        this.damage = damage;
        this.speed = speed;
        this._rb2D = _rb2D;
        this._sprite = _sprite;

    }

    public Sprite GetSprite()
    {
        return _sprite;
    }

    public abstract void Move();


    public virtual void Hit()
    {

    }

}
