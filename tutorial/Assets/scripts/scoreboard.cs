using UnityEngine;
using UnityEngine.UI;

public class scoreboard : MonoBehaviour
{    
    public Transform player;
    public Text score;
    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<gameManager>().gameover)
        {
            score.text = "Game Over!";
        }
        else
        {
            score.text = player.position.z.ToString("0");
        }
    }
}
