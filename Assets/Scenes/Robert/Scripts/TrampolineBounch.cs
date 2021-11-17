using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class TrampolineBounch : MonoBehaviour
{
    Transform myParent;

    // Explosion/Bounch Related
    [SerializeField] float force = 10f;
    [SerializeField] float radius = 10f;

    // Audio Related
    AudioSource audioSource;

    // Animation Related
    [SerializeField] Animator trampolineAnimator;



    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        myParent = GetComponentInParent<Transform>();
    }

    void Update()
    {
        if(trampolineAnimator.GetBool("Actor_Present") == false)
        {
            //myParent.position = new Vector3(myParent.position.x, 0f, myParent.position.z);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
            trampolineAnimator.SetBool("Actor_Present", true);

            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

            rb.AddExplosionForce(force, transform.position, radius);
        }
    }

    void OnTriggerExit(Collider other)
    {
        trampolineAnimator.SetBool("Actor_Present", false);
    }
}
