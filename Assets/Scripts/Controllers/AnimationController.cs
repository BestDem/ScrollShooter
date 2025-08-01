using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void AnimatorEnemy(string nameAnim, bool anim)
    {

        if (nameAnim == "isAttack")
            animator.SetBool("isAttack", anim);

        else if (nameAnim == "isMoving")
            animator.SetBool("isMoving", anim);
        else
            return;
    }
    
}
