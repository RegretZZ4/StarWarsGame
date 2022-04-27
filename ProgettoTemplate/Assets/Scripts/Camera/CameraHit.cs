using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraHit : MonoBehaviour
{
    Color hit_material;
    [SerializeField] Image panel;
    //Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        //camera = GetComponent<Camera>();
       // camera.clearFlags = CameraClearFlags.SolidColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMaterial_inRed()
    {
        hit_material = new Color(178, 48, 48, 255); //rosso

        panel = GetComponent<Image>();

        panel.color = hit_material;
        

       // camera.backgroundColor = hit_material;
    }

    public void ChangeMaterial_inTrasparent()
    {
        hit_material = new Color(255, 255, 255, 0);
        // camera.backgroundColor = hit_material;

        panel = GetComponent<Image>();

        panel.color = hit_material;
    }
}
