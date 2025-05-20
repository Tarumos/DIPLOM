using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableProps : MonoBehaviour
{
    // Start is called before the first frame update
    public float health;

    public void TakeDamage(float dmg)
    {
        health -= dmg;

        if(health <= 0)
        {
            kill();
        }
    }
    public void kill()
    {
        Destroy(gameObject);
    }
}
