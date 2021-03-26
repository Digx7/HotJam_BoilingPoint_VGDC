using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGasMode : MonoBehaviour
{
    public Vector2 moveVec;
    private Rigidbody2D gasBody;
    public float speed;
    private Vector2 UP;
    private Vector2 DN;
    private Vector2 LT;
    private Vector2 RT;
    private Vector2 NN;
    Gascontrols controls;

    private void Awake()
    {
        controls = new Gascontrols();
        gasBody = GetComponent<Rigidbody2D>();
        UP = new Vector2(0, 1);
        DN = new Vector2(0, -1);
        LT = new Vector2(-1, 0);
        RT = new Vector2(1, 0);
        NN = new Vector2(0, 0);

        controls.gasmode.Move.performed += gasModeMoveContext => moveVec = gasModeMoveContext.ReadValue<Vector2>();
        controls.gasmode.Move.canceled += gasModeMoveContext => moveVec = Vector2.zero;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleMove()
    {
        Vector2 m = new Vector2(moveVec.x * speed, moveVec.y * speed) * Time.deltaTime;
        transform.Translate(m, Space.World);
       
    }

    private void FixedUpdate()
    {
        HandleMove();
    }

    public void OnMove(InputValue input)
    {
        Vector2 inputVec = input.Get<Vector2>();

        moveVec = new Vector2(inputVec.x, inputVec.y);
    }

    private void OnEnable()
    {
        controls.gasmode.Enable();
    }

    private void OnDisable()
    {
        controls.gasmode.Disable();
    }
}
