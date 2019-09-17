using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiCube : Ennemi {
    GameObject player;
    public float speed = 5;
    Rigidbody rb;
    AudioSource audioSource;
    public AudioMusic audioMusic;
    public GameObject particuleSystemDeath;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
        audioSource = GameObject.FindGameObjectWithTag("SoundPlayer").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        FollowPlayer();
    }

    public void FollowPlayer()
    {
        rb.MovePosition(Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime));
    }

    public override void Die()
    {
        audioSource.PlayOneShot(audioMusic.soundToPlay);
        Instantiate(particuleSystemDeath, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
