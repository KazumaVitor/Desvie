using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject victoryText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            victoryText.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}