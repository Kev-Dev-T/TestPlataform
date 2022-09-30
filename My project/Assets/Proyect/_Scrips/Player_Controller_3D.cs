using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller_3D : MonoBehaviour
{
    public float Speed;
    public float TunSpeed;
    public bool Jump;
    public float JumpForce;
    Rigidbody _rigidbody;
    public Animator _AnimationController;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Jump)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                _AnimationController.SetTrigger("");
                _rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            }
        }

        Move();
    }

    public void Move()
    {
        float MoveVertical = Input.GetAxis("Vertical");
        float MoveHorizontal = Input.GetAxis("Horizontal");

        if (MoveVertical < 0 || MoveVertical < 0) _AnimationController.SetBool("",true);
        else _AnimationController.SetBool("", false);

        transform.Translate(0, 0, MoveVertical*Speed*Time.deltaTime);
        transform.Rotate(0, MoveHorizontal, 0*TunSpeed*Time.deltaTime);
        
        
    }
}
