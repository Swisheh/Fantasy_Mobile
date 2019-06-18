using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    #region Global Fields
    [Tooltip("Player Health")]
    [SerializeField]
    private float playerHealth = 100;
    [Tooltip("Player Speed")]
    [SerializeField]
    private float playerSpeed = 4;
    [Tooltip("Player Anim Controller")]
    [SerializeField]
    private RuntimeAnimatorController playerAnimCont;

    float horizontalMove;
    float verticalMove;

    private Rigidbody rb;
    private Animator anim;
    #endregion

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
        anim.runtimeAnimatorController = playerAnimCont;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        Moving();
    }

    public void Moving()
    {
        if (horizontalMove > 0)
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime, Space.World);
        }
        else if (horizontalMove < 0)
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime, Space.World);
        }

        if (verticalMove > 0)
        {
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime, Space.World);            
        }
        else if (verticalMove < 0)
        {
            transform.Translate(Vector3.back * playerSpeed * Time.deltaTime, Space.World);            
        }

        if(horizontalMove != 0 || verticalMove != 0) 
        {
            Vector3 movement = new Vector3(horizontalMove, 0.0f, verticalMove);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F); // rotates to face direction moving

            anim.SetBool("walking", true);
        }
        else
        {
            anim.SetBool("walking", false);
        }
    }
}
