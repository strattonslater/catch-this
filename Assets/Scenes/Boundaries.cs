using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour {
    public Camera MainCamera;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;


    // Use this for initialization
    void Start () {
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x; //extents = size of width / 2
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y; //extents = size of height / 2
    }

    // Update is called once per frame
    void LateUpdate(){
        Vector3 viewPos = gameObject.transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth*2, screenBounds.x - objectWidth*2);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + objectHeight/8, screenBounds.y - objectHeight);
        gameObject.transform.position = viewPos;
    }
}