using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEffectiveness: MonoBehaviour
{
    public GameObject explosion;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Limo"))
        {
            Player.instance.LimoCrash();
            TriggerExplosionVFX();
        }
        if (collision.gameObject.tag.Equals("Guard"))
        {
            TriggerExplosionVFX();
        }
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            TriggerExplosionVFX();
        }
    }
    public void TriggerExplosionVFX()
    {
        this.gameObject.SetActive(false);
        GameObject sparkles = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(sparkles, 2f);
    }
}
