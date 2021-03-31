using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallScript : MonoBehaviour
{
    public LayerMask whatIsProp;

    public ParticleSystem explosionParticle;

    public AudioSource explosionSound;

    public float maxDamage = 100f; //물건에 줄 수 있는 최대 뎀지 
    public float explosionForce = 1000f;
    public float lifeTime = 8f;
    public float explosionRadius = 20f;
   
    void Start()
    {
        Destroy(gameObject,lifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius,whatIsProp);

        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();

            targetRigidbody.AddExplosionForce(explosionForce,transform.position,explosionRadius);//폭발의 힘, 폭발의 중심지(폭심), 폭발반경 
            Prop targetProp = colliders[i].GetComponent<Prop>();
            float damage = CalculateDmg(colliders[i].transform.position);
            targetProp.TakeDamage(damage);
        }
        explosionParticle.transform.parent = null;

        explosionParticle.Play();
        explosionSound.Play();
        Destroy(explosionParticle.gameObject,explosionParticle.duration);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private float CalculateDmg(Vector3 targetPosition)
    {
        Vector3 explosionToTarget = targetPosition - transform.position;

        float distance = explosionToTarget.magnitude;

        float edgeToCenterDistance = explosionRadius - distance;
        float percentage = edgeToCenterDistance / explosionRadius;
        float damage = maxDamage * percentage;
        damage = Math.Max(0, damage);
        return damage;
    }
}
