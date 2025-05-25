using UnityEngine;

public class Collectible : MonoBehaviour
{
    int timer = 0;
    float seconds = 0f;
    float value = 0.005F;
    public float rotSpeed = 0.5f;
    public GameObject onCollectEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        transform.Rotate(0, rotSpeed, 0); 
        timer++;
        if(timer == 15) {seconds+= 0.5f;}


        
        if (seconds == 12f){
            value = 0.002f;
            seconds = 0;
        }
        else if(seconds == 6f){
            value = -0.002F;
        }
        
        if(timer == 15) {transform.Translate(0, value, 0); timer = 0;}


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player")) {
 
        Destroy(gameObject);
        Instantiate(onCollectEffect, transform.position, transform.rotation);
}
        
    }
}
