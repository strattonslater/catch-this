using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GAMECONTROLLER : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _timeText;
    [SerializeField] private GameObject PLAYER;
    [SerializeField] private THROWERSCRIPT THROWER;
    [SerializeField] private Camera MainCamera;
    [SerializeField] private GameObject TitleScreen;

    public float timeValue=60;
    bool spacePressed = false;

    private GameObject activePlayer;
    private Vector3 playerPosition;
    //
    public GameObject getPlayer(){
        return activePlayer;
    }
    // Start is called before the first frame update
    void Start()
    {
        timeValue = 0;
    }

    public void gameStart()
    {
        activePlayer = Instantiate(PLAYER, new Vector3(0, -4f, 0), Quaternion.identity);
        activePlayer.GetComponent<Boundaries>().MainCamera=MainCamera;
        THROWER.setGameController(gameObject.GetComponent<GAMECONTROLLER>());
        THROWER.throwerStart();
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Space) && spacePressed == false)
    {
        TitleScreen.SetActive(false);
        timeValue = 61;
        spacePressed = true;
        gameStart();
    }
        if(spacePressed)
        playerPosition = activePlayer.transform.position;

        //Debug.Log(playerPosition);

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
