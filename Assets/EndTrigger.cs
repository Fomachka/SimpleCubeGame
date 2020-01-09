using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    // A code will execute on trigger since the trigger object can't be collided with
    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
