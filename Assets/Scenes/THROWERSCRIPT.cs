using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THROWERSCRIPT : MonoBehaviour
{
    [SerializeField] private GAMECONTROLLER gameController;

    [SerializeField] private particleCollision[] emitters;

    GameObject activePlayer;

    bool isStarted = false;

    public void setGameController(GAMECONTROLLER GC)
    {
        gameController = GC;
        for(int i=0;i<emitters.Length;i++){
            emitters[i].setGameController(GC);
        }
    }
    public void throwerStart()
    {
        isStarted = true;
        activePlayer = gameController.getPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if(isStarted == true)
        {
        transform.right = activePlayer.transform.position - transform.position;
        }
    }


}
