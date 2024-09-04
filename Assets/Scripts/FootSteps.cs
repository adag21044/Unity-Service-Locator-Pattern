using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioSource audioSource;

    private void Update()
    {
        bool isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);
        audioSource.enabled = isMoving;
    }
}
