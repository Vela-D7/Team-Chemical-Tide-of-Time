using UnityEngine;

public class CaptainEliasFollow : MonoBehaviour
{
    public Transform player;  // Assign the XR Rig in the Inspector
    public float followDistance = 2.5f; 
    public float speed = 2.0f;  
    public Animator animator;

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > followDistance)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
            transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));

            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
