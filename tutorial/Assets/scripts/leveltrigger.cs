using UnityEngine;

public class leveltrigger : MonoBehaviour
{
    public gameManager gm;
   void OnTriggerEnter()
   {
       gm.CompleteLevel();
   }
}
