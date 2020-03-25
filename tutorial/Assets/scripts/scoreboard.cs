using UnityEngine;
using UnityEngine.UI;

public class scoreboard : MonoBehaviour
{    
    public Transform player;
    public Text score;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.position.z.ToString("0"));
        score.text = player.position.z.ToString("0");
    }
}
