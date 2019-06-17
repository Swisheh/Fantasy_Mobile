using UnityEngine;
using System.Collections;

public class ZombieScript : MonoBehaviour {

    public float speed = -0.5f;
    private Rigidbody2D zomb;

	// Use this for initialization
	void Awake () {
        zomb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        zomb.velocity = new Vector2(speed, zomb.velocity.y);
    }
}
