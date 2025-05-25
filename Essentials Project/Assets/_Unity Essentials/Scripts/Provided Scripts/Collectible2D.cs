using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible2D : MonoBehaviour
{

    public float rotationSpeed = 0.5f;
    public GameObject onCollectEffect;

    private Vector2 movement;
    int timer = 0;
    float seconds = 0;
    float value = .05f;

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, rotationSpeed);
        timer++;
        if (timer == 15)
        {
            //movement = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
            timer = 0;
            transform.Translate(Random.Range(-.05f, .05f), Random.Range(-.05f, .05f),0);

        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
         // Check if the other object has a PlayerController2D component
        if (other.GetComponent<PlayerController2D>() != null) {
            
            // Destroy the collectible
            Destroy(gameObject);

            // Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }

        
    }


}


