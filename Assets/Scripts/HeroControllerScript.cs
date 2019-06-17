using UnityEngine;
using System.Collections;

public class HeroControllerScript : MonoBehaviour {

    public float speed = 1f;
    public GameObject weapon;
    private Rigidbody2D hero;
    
    Animator anim;

	// Use this for initialization
	void Awake () {
        hero = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        anim.SetFloat("Speed", speed);
        hero.velocity = new Vector2(speed, hero.velocity.y);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemies"))
        {
            speed = 0f;
            anim.SetBool("Slash_Attack", true);      
        }
    }

    
}
