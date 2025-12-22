using UnityEngine;
using UnityEngine.Video;

public class TVOn : MonoBehaviour
{
    public VideoPlayer tvStatic;
    public GameObject tvOff;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tvStatic.Play();
            tvOff.SetActive(false);
            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tvStatic.Stop();
            tvOff.SetActive(true);
        }
    }
}
