using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class Ennemi : MonoBehaviour , Damage{
    private int lifeTotalEnnemi1 = 1;
    private int lifeTotalEnnemi2 = 15;
    public void TakeDamage(int damage)
    {
        if (gameObject.tag == "Ennemi1")
        {
            lifeTotalEnnemi1 -= damage;
            if (lifeTotalEnnemi1 <= 0)
            {
                Die();
            }
        }

        if (gameObject.tag == "Ennemi2")
        {
            lifeTotalEnnemi2 -= damage;
            if (lifeTotalEnnemi2 <= 0)
            {
                Die();
            }
        }

    }

    public abstract void Die();

    protected void SetLife(int newlifeTotal)
    {
        lifeTotalEnnemi1 = newlifeTotal;
    }
}
