using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYERSCRIPT : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidBody;
    [SerializeField] private int _movementforce;
    [SerializeField] private GameObject THROWER;

    public ParticleSystem part;

    // Start is called before the first frame update
    void Start()
    {
        // part = GetComponent<THROWER>();
        
    }

    // Update is called once per frame
    void Update()
    {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _rigidBody.AddForce(new Vector2(0, _movementforce));
            }
                    if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _rigidBody.AddForce(new Vector2(0, -_movementforce));
            }
                    if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _rigidBody.AddForce(new Vector2(-_movementforce, 0));
            }
                    if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                _rigidBody.AddForce(new Vector2(_movementforce, 0));
            }
            
                    if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                _rigidBody.AddForce(new Vector2(0, -_movementforce));
            }
                    if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                _rigidBody.AddForce(new Vector2(0, _movementforce));
            }
                    if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                _rigidBody.AddForce(new Vector2(_movementforce, 0));
            }
                    if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                _rigidBody.AddForce(new Vector2(-_movementforce, 0));
            }
    }

    // void OnParticleCollision(THROWER)
    // {
    //     Debug.Log("Ouch!");
    // }
}
