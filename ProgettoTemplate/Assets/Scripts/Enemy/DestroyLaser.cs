using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLaser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LaserDestroy", 8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LaserDestroy()
    {
        Destroy(this.gameObject);
    }
}
