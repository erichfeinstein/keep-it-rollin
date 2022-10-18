using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D PlayerBody;
    [SerializeField] private float Speed;
    [SerializeField] private float JumpForce;
    // Start is called before the first frame update
    // void Start()
    // {
    //     PlayerBody = GetComponent<Rigidbody>();
    // }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left")) {
            PlayerBody.AddForce(new Vector2(-Speed, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKey("right")) {
            PlayerBody.AddForce(new Vector2(Speed, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown("space")) {
            PlayerBody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
