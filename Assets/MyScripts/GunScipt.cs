using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScipt : MonoBehaviour {

    public GameObject gameobject;
    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        
    }

    public void FireGun()
    {
        Instantiate(gameobject);
    }
}
