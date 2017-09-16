using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float speed = 3;
    public int Dies = 5;
    private float timer = 0;
    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if(timer <= Dies)
        {
            timer += Time.deltaTime;
            if(timer >= Dies)
                Destroy(gameObject);
          
        }
    }
}
