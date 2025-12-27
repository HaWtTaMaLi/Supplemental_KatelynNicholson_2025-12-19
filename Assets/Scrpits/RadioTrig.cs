using UnityEngine;

public class RadioTrig : MonoBehaviour
{
    public AudioSource radioSound;
    public bool isPlaying = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!isPlaying)
            {
                radioSound.Play();
                isPlaying = true;
            }
            else
            {
                radioSound.Pause();
                isPlaying = false;
            }
        }
    }
}
