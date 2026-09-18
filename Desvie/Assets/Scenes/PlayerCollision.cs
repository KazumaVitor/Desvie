using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject defeatText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            defeatText.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
