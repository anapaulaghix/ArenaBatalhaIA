using UnityEngine;

public class DragonAttck : MonoBehaviour
{
    public int HP = 100;
    public Animator animator;

    [Header("Death Effects")]
    public ParticleSystem fireEffect;

    private bool isDead = false;

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        HP -= damage;

        if (HP <= 0)
        {
            Die();
        }
        else
        {
            animator.SetTrigger("damage");
        }
    }

    void Die()
    {
        isDead = true;

        animator.SetTrigger("die");

        GetComponent<Collider>().enabled = false;

        if (fireEffect != null)
        {
            fireEffect.Play();
        }
    }
}
