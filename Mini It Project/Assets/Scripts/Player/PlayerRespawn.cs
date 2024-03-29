using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private AudioClip checkpoint;
    private Transform currentCheckpoint;
    private Health playerHealth;
    private UIManager uiManager;

    private void Awake()
    {
        playerHealth = GetComponent<Health>();
        uiManager = FindObjectOfType<UIManager>(); //Careful for duplicate (Game Over TUT 3.24)
    }

    public void CheckRespawn()
    {
        //Check if checkpoint available
        if (currentCheckpoint == null)
        {
            //Show game over screen
            uiManager.GameOver();
            return; //Dont execute this function
        
        }
        playerHealth.Respawn();// Restore player health and reset animation
        transform.position = currentCheckpoint.position; //Move player to checkpoint position
         

        //move the camera back to the player
        // Camera.main.GetComponent<CameraController>().MoveToNewRoom(currentCheckpoint.parent);
    }

    //Activate checkpoints

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Checkpoint")
        {
            currentCheckpoint = collision.transform; //Store the checkpoint that we activated as the current one
            SoundManager.instance.PlaySound(checkpoint);
            collision.GetComponent<Collider2D>().enabled = false; //Deactivate checkpoint collider
            collision.GetComponent<Animator>().SetTrigger("appear"); //Triger checkpoint animation
        
        }
    }
}
    

    
