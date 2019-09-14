using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    private Transform target;

    public float speed = 2f;

    public Transform groundDetector;
    //public Transform wallDetector;

    public bool facingRight = false;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        if (facingRight == true)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
                facingRight = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        RaycastHit2D ground = Physics2D.Raycast(groundDetector.position, Vector2.down, 2f);
        if (ground.collider == false)
        {
            if (facingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                facingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                facingRight = true;
            }
        }
    }
}
