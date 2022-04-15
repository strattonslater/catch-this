using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMECONTROLLER : MonoBehaviour
{
    [SerializeField] private GameObject PLAYER;
    [SerializeField] private GameObject THROWER;

    private GameObject activePlayer;
    private Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        activePlayer = Instantiate(PLAYER);
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = activePlayer.transform.position;
        Debug.Log(playerPosition);
    }
}
