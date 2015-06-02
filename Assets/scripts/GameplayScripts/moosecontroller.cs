using UnityEngine;
using System.Collections;

public class moosecontroller : MonoBehaviour
{

    PausMenu pause;

    public float maxSpeed;
    Animator anim;

    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    bool onRoof = false;
    public Transform roofCheck;
    float roofRadius = 0.2f;
    public LayerMask whatIsRoof;


    void Start()
    {
        // hämtar animationen till älgen
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        //Kollar om boolarna är sanna eller inte
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", grounded);

        onRoof = Physics2D.OverlapCircle(roofCheck.position, roofRadius, whatIsRoof);
        anim.SetBool("Roof", onRoof);

        // hur snabbt älgen rör sig
        anim.SetFloat("Speed", Time.deltaTime);

        //ger älgen hastighet
        GetComponent<Rigidbody2D>().velocity = new Vector2(1 * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

    }

    void Update()
    {
        if ((grounded) && Input.GetKeyDown(KeyCode.Space))
        {
            // kollar vilket håll gravitation ska vara åt
            anim.SetBool("Ground", false);
            GetComponent<Rigidbody2D>().gravityScale *= -1;
            onRoof = true;
            
        }
        else if ((onRoof) && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Roof", false);
            GetComponent<Rigidbody2D>().gravityScale *= -1;
            Debug.Log("test ändra gravitation");
        }
    }
}
