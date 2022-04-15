using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMECONTROLLER : MonoBehaviour
{
    [SerializeField] private GameObject PLAYER;
    [SerializeField] private GameObject THROWER;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(PLAYER);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
