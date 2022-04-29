using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GAMECONTROLLER : MonoBehaviour
{

    [SerializeField] private TextMeshPro _timeText;
    [SerializeField] private GameObject PLAYER;
    [SerializeField] private GameObject THROWER;
    [SerializeField] private Camera MainCamera;

    public float timeValue=60;

    public GameObject activePlayer;
    private Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        activePlayer = Instantiate(PLAYER, new Vector3(0, -4f, 0), Quaternion.identity);
        activePlayer.GetComponent<Boundaries>().MainCamera=MainCamera;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = activePlayer.transform.position;
        Debug.Log(playerPosition);

        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);  
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        _timeText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }
}
