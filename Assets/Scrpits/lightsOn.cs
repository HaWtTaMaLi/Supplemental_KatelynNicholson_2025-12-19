using UnityEngine;
using UnityEngine.Playables;

public class lightsOn : MonoBehaviour
{
    public PlayableDirector animationClip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animationClip.Play();
        }
    }
}
