using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraHit : MonoBehaviour
{
    
    //Color hit_material;
    float alpha = 74f;
    [SerializeField] Material material;
    //Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        material.color = new Color(139f, 0f, 0f, 0f);
        //this.gameObject.SetActive(false);
        //camera = GetComponent<Camera>();
        // camera.clearFlags = CameraClearFlags.SolidColor;


    }

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "enemyLaser")
        {
            Debug.Log("sono stato colpito");

            ChangeMaterial_inRed();

            
        }
    }
    

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeMaterial_inRed()
    {
        //this.gameObject.SetActive(true);
        material.color = new Color(139f, 0f, 0f, alpha);

        Invoke("ChangeMaterial_inTrasparent", 0.2f);
    }

    public void ChangeMaterial_inTrasparent()
    {
        material.color = new Color(139f, 0f, 0f, 0f);

        //this.gameObject.SetActive(false);
    }//
}
