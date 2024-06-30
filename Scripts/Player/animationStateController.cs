
using Unity.VisualScripting;
using UnityEngine;

public class animationStateController : MonoBehaviour
{

    public Animator animator;
    [SerializeField] private LayerMask playerMask;

    private void Awake()
    {
        animator = GetComponent<Animator>();

        animator.SetBool("isRunning", true);
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.layer == 6)
        {
            animator.SetBool("isRunning", false);
        }

    }


}
