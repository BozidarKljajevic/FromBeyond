using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController _controller;
    public Transform cam;
    [SerializeField]
    private float _speed = 5.0f;
    private float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    [SerializeField]
    private float _gravity = 9.81f;
    [SerializeField]
    private float _jump = 15.0f;

    private float _yVelocity = 0.0f;
    private bool _doubleJump = false;

    [SerializeField]
    private GameObject _laser;
    [SerializeField]
    private GameObject _fireBall;

    private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        //if (direction.magnitude >= 0.1f)
        //{

            /*float tatargetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, tatargetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, tatargetAngle, 0f) * Vector3.forward;*/

            velocity = direction * _speed;

            
        //}

        if (Input.GetKey(KeyCode.E))
        {
            _laser.SetActive(true);
            /*Ray rayOrigin = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;

            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                Debug.Log("Hit" + hitInfo.transform.name);
            }*/
        }
        else
        {
            _laser.SetActive(false);

            _laser.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            _fireBall.SetActive(true);

        }
        else
        {
            _fireBall.SetActive(false);

            _fireBall.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
        }

        if (_controller.isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                 _yVelocity = _jump;
                 _doubleJump = true;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_doubleJump == true)
                {
                    _yVelocity = _jump;
                    _doubleJump = false;
                }
            }
            _yVelocity -= _gravity;
        }

        velocity.y = _yVelocity;
        _controller.Move(velocity * Time.deltaTime);

    }
}
