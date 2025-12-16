using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public int damageRange = 20;
    private void Start()
    {
        Destroy(gameObject, 10);
    }
    private void OnTriggerEnter(Collider colider)
    {
        Destroy(transform.GetComponent<Rigidbody>());
        if(colider.tag == "dragon")
        {
            transform.parent = colider.transform;
            colider.GetComponent<DragonAttck>().TakeDamage(damageRange);
        }
    }
}
