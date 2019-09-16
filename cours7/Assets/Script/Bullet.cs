using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Rigidbody rb;
    public int lifeSpan = 3;
    public int bulletSpeed = 100;
    public int bulletDamage = 1;
    private float timeLeftToLive;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        timeLeftToLive = lifeSpan;
	}
	
	// Update is called once per frame
	void Update () {
        rb.MovePosition(rb.position + transform.forward * bulletSpeed * Time.deltaTime);
        ApplyLifeSpan();


    }

    private void ApplyLifeSpan()
    {
        timeLeftToLive -= Time.deltaTime;
        if (timeLeftToLive < 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    public void OnTriggerEnter(Collider otherObject)
    {
        Damage grosDamage = otherObject.GetComponentInParent<Damage>();
        if (grosDamage != null)
        {
            grosDamage.TakeDamage(bulletDamage);
        }

        Die();
    }
}
