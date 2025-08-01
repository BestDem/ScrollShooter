using UnityEngine;

public class AnimationPlayerController : MonoBehaviour
{
    public static AnimationPlayerController singltonAnim { get; private set; }
    private Animator animator;

    private void Awake()
    {
        singltonAnim = this;
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
