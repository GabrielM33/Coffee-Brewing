using UnityEngine;

public class BubblePop : MonoBehaviour
{
    [SerializeField] private AudioSource popSound;
    [SerializeField] private GameObject popEffect;
    private void OnTriggerEnter(Collider other)
    {
        // if hand collides with bubble, pop bubble
        if (other.gameObject.CompareTag("Hand"))
        {
            PopBubble();
        }
    }

    private void PopBubble()
    {
        gameObject.SetActive(false);
        popSound.Play();
    }
}
