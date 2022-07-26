using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;
    public float damage = 3f;
    public float lifeTime = 1.5f;
    private float counter = 0f;

  
    private void Update()
    {
        counter += Time.deltaTime;
        if(counter > lifeTime) {
            Destroy(gameObject);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision");
        Destroy(gameObject);
    }
}
