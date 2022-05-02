using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THROWERSCRIPT : MonoBehaviour
{
    [SerializeField] private GAMECONTROLLER gameController;

    GameObject activePlayer;

    bool isStarted = false;

    // The target marker.
    public Transform target;

    // Angular speed in radians per sec.
    public float speed = 1.0f;

    // Start is called before the first frame update

    public void setGameController(GAMECONTROLLER GC)
    {
        gameController = GC;
    }
    public void throwerStart()
    {
        isStarted = true;
        activePlayer = gameController.getPlayer();
        //target.position = activePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(isStarted==true)
        {
        Debug.Log(activePlayer.transform.position);
        }

        // // Determine which direction to rotate towards
        // Vector3 targetDirection = target.position - transform.position;

        // // The step size is equal to speed times frame time.
        // float singleStep = speed * Time.deltaTime;

        // // Rotate the forward vector towards the target direction by one step
        // Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        // // Draw a ray pointing at our target in
        // Debug.DrawRay(transform.position, newDirection, Color.red);

        // // Calculate a rotation a step closer to the target and applies rotation to this object
        // transform.rotation = Quaternion.LookRotation(newDirection);

        transform.LookAt(transform.position + new Vector3(0,0,1), activePlayer.transform.position);
        // Vector3 vectorToTarget = activePlayer.transform.position - gameObject.transform.position;
        // float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        // Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        // gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, q, Time.deltaTime * speed);
    }
}
