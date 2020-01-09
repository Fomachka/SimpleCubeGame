using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    private void Update()
    {
        //converts float to a full string (without decimal point)
        scoreText.text = player.position.z.ToString("0");
    }

}
