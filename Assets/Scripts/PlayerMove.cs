using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController _controller;
    public Transform cam;
    [SerializeField]
    private float _speed = 5f;
    private float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    [SerializeField]
    private float _gravity = 9.81f;
    [SerializeField]
    private float _jump = 3.5f;
    [SerializeField]
    private float _doubleJumpMulitiplier = 0.8f;

    private float _yDirection = 0.0f;
    private float _yVelocity = 0.0f;
    private bool _doubleJump = false;
    private Vector3 helpMoveVector;
    private Vector3 velocity;
    [SerializeField]
    private GameObject _laser;
    [SerializeField]
    private GameObject _fireBall;
    //public GameObject heal;

    private Vector3 moveDir;

    public bool hasKey = false;
    public bool hasSkull = false;
    public bool hasExtraLife = false;
    public GameObject player;

    bool isTime = true;
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

        var playerObject = GameObject.Find("Third Person Player");
        
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                helpMoveVector = new Vector3(0, 0, 1);
                moveDir = Quaternion.Euler(0f, targetAngle, 0f) * helpMoveVector;
                if (player != null)//&& _controller.isGrounded == true
                {
                    player.GetComponent<Animator>().SetBool("IsWalking", true);
                }
            }
            else
            {
                helpMoveVector = new Vector3(0, 0, 0);
                moveDir = Quaternion.Euler(0f, targetAngle, 0f) * helpMoveVector;
                if (player != null)
                {
                    player.GetComponent<Animator>().SetBool("IsWalking", false);
                }
            }
        }
        
            velocity = moveDir * _speed;



        if (_controller.isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (player != null)
                {
                    player.GetComponent<Animator>().SetBool("IsJumping", true);
                    player.GetComponent<Animator>().SetBool("IsWalking", false);
                }
                _yVelocity = _jump;
                _doubleJump = true;
            }
            else
            {
                if (player != null && _controller.isGrounded == true)
                {
                    player.GetComponent<Animator>().SetBool("IsJumping", false);
                }
            }
                
        }
        else
        {
            player.GetComponent<Animator>().SetBool("IsFalling", true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_doubleJump == true)
                {
                    _yVelocity = _jump;
                    _doubleJump = false;
                }
            }
            _yVelocity -= _gravity * Time.deltaTime;
        }

          velocity.y = _yVelocity;

        _controller.Move(velocity * Time.deltaTime);


        /*if (_controller.isGrounded == true)
        {

        
            if (Input.GetKey(KeyCode.E) && isTime == true)
            {
                Debug.Log("dRUGI IF");
                heal.SetActive(true);
                StartCoroutine(WaitForHalfASecond());
                StartCoroutine(WaitForHalfASecond1());
                Debug.Log(isTime);
            }
            else
            {
                heal.SetActive(false);
            }
         
        }*/

        if (Input.GetKey(KeyCode.Q))
        {
            _fireBall.SetActive(true);

        }
        else
        {
            _fireBall.SetActive(false);

            _fireBall.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
        }
    }

    /*IEnumerator WaitForHalfASecond()
    {
        yield return new WaitForSeconds(5f);
        heal.SetActive(false);
        isTime = false;
    }

    IEnumerator WaitForHalfASecond1()
    {
        yield return new WaitForSeconds(30f);
        isTime = true;
    }*/

}

