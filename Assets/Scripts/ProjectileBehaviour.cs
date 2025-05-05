using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float aliveTime = 5;
  
    private float currentTime = 0;
    public ProjectileType projectileType;
    private Projectiles projectiles;

    // Start is called before the first frame update
    void Start()
    {
        switch (projectileType)
        {
            case ProjectileType.ARROW:
                projectiles = new Arrow(25, 30,GetComponent<Rigidbody2D>(),GetComponent<Sprite>());
                break;
            case ProjectileType.ICEARROW:
                projectiles = new IceArrow(10, 15, GetComponent<Rigidbody2D>(), GetComponent<Sprite>());
                break;
            case ProjectileType.BOOMERANG:
                projectiles = new Boomerang(8, 10, GetComponent<Rigidbody2D>(), GetComponent<Sprite>());
                break;
        }

    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > aliveTime) 
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Enemy>())
        {

        }
    }
}
