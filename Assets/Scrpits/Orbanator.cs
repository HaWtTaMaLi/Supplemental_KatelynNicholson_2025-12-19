using UnityEngine;

public class Orbanator : MonoBehaviour
{
    public Animator orbanator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            orbanator.SetTrigger("PlayAnim");
        }
    }
}
