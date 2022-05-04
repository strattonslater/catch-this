using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYERSCRIPT : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidBody;
    [SerializeField] private int _movementforce;
    [SerializeField] private GameObject THROWER;

    bool someBoolean = false;
    public bool wasHit = false;
    public ParticleSystem part;



    // Start is called before the first frame update
    void Start()
    {
        // part = GetComponent<THROWER>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(someBoolean == false)
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

                            if (Input.GetKeyDown(KeyCode.W))
                {
                    _rigidBody.AddForce(new Vector2(0, _movementforce));
                }
                        if (Input.GetKeyDown(KeyCode.S))
                {
                    _rigidBody.AddForce(new Vector2(0, -_movementforce));
                }
                        if (Input.GetKeyDown(KeyCode.A))
                {
                    _rigidBody.AddForce(new Vector2(-_movementforce, 0));
                }
                        if (Input.GetKeyDown(KeyCode.D))
                {
                    _rigidBody.AddForce(new Vector2(_movementforce, 0));
                }
                
                        if (Input.GetKeyUp(KeyCode.W))
                {
                    _rigidBody.AddForce(new Vector2(0, -_movementforce));
                }
                        if (Input.GetKeyUp(KeyCode.S))
                {
                    _rigidBody.AddForce(new Vector2(0, _movementforce));
                }
                        if (Input.GetKeyUp(KeyCode.A))
                {
                    _rigidBody.AddForce(new Vector2(_movementforce, 0));
                }
                        if (Input.GetKeyUp(KeyCode.D))
                {
                    _rigidBody.AddForce(new Vector2(-_movementforce, 0));
                }

        }
    }

    public void endWait()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void OnParticleCollision(GameObject other)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        wasHit = true;
        someBoolean = true;
        Invoke("endWait", 2.0f);
        // Debug.Log("Ouch!");
        
        // Debug.Log(wasHit);
    }
}
