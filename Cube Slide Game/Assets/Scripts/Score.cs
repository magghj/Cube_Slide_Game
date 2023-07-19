using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {

    public Transform player;
    public TextMeshProUGUI scoreText;

    float m_Hue;
    float m_Saturation;
    float m_Value;

    void Update()
    {
        if (player.position.z > 0f)
        {
            scoreText.fontSize = 64;
            scoreText.color = new Color(1f, 0.9563f, 0.4117f, 1.0f);
            scoreText.text = player.position.z.ToString("0");
        }
        else if (player.position.z >= -20f)
        {
            scoreText.fontSize = 88;
            scoreText.color = Color.green;
            scoreText.text = "GO";
        }
        else if (player.position.z >= -40f)
        {
            scoreText.fontSize = 76;
            scoreText.color = Color.yellow;
            scoreText.text = "Set";
        }
        else
        {
            scoreText.fontSize = 64;
            scoreText.color = Color.red;
            scoreText.text = "Ready";
        }
    }
}
