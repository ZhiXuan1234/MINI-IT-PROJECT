using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] bool goNextLevel;
    [SerializeField] string levelName;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (goNextLevel)
            {
                ScenceController.instance.NextLevel();
            }
            else
            {   
                ScenceController.instance.LoadScene(levelName);
            }
            
            
        }
    }
}
