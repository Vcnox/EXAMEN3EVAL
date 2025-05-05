using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float timeToShoot = 0.4f;
    public GameObject projectiles;

    private float currentTime = 0;

    public ProjectileType projectileType;
    private Projectiles Projectiles;



    // Start is called before the first frame update
    void Start()
    {
        switch (projectileType)
        {
            case ProjectileType.ARROW:
                projectiles = new Arrow(25, 30);
                break;
            case ProjectileType.ICEARROW:
                projectiles = new IceArrow(10, 15);
                break;
            case ProjectileType.BOOMERANG:
                projectiles = new Boomerang(8, 10);
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > timeToShoot && Input.GetMouseButton(0))
        {

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
