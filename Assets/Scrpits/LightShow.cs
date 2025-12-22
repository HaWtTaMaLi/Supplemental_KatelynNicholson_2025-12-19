using UnityEngine;
using UnityEngine.Playables;

public class LightShow : MonoBehaviour
{
    public PlayableDirector lightShowEvent;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lightShowEvent.Play();
        }
    }
}
