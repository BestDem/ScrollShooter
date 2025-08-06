using UnityEngine;

public class AnimationPlayerController : MonoBehaviour
{
    public static AnimationPlayerController singletonAnim { get; private set; }
    private Animator animator;

    private void Awake()
    {
        if (singletonAnim == null)
            singletonAnim = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void AnimatorPlayer(string nameAnim, bool anim)
    {

        if (nameAnim == "Death")
            animator.SetBool("Death", anim);

        else if (nameAnim == "isDamage")
            animator.SetTrigger("isDamage");

        else if (nameAnim == "Attack")
            animator.SetTrigger("Attack");

        else if (nameAnim == "isJump")
            animator.SetTrigger("isJump");

        else if (nameAnim == "isRunning")
            animator.SetBool("isRunning", anim);

        else
            return;
    }
}
