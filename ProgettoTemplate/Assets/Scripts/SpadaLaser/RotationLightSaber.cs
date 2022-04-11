using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class RotationLightSaber : MonoBehaviour
{
    Vector3 angleVelocity;
    XRGrabInteractable grab;
    Rigidbody rigidbody;

    [SerializeField] Transform PosSaber;
    
    
    bool count;
    // Start is called before the first frame update
    void Start()
    {
        //angleVelocity = new Vector3(90, 0, 0);
        count = false;
        grab = GetComponent<XRGrabInteractable>();

        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // RotateSaber();
       
    }

    public void GetRotationSaber()
    {
        
        //var rigidbody = GetComponent<Rigidbody>();
        //if (rigidbody.velocity.magnitude > 0)
       // {
            Debug.LogWarning("ROTAZIONE");
        //grab.enabled = false;

        rigidbody.useGravity = false;

            rigidbody.AddForce(transform.up * 10f, ForceMode.Impulse);
     
            rigidbody.AddTorque(transform.right * 50000f, ForceMode.Impulse);

            Invoke("ReturnToHand", 2f);
      //  }



    }

    public IEnumerator RotationCoroutine()
    {
        yield return 0;
    }

    public void ReturnToHand()
    {
        rigidbody.useGravity = true;
        Debug.LogWarning("RETURN HAND");
        //grab.enabled = true;
      //  var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        this.transform.eulerAngles = new Vector3(90, 0, 0);

        //var positionHand = GameObject.Find("RightHand");
       // rigidbody.isKinematic = true;

        this.transform.position = PosSaber.transform.position;
    }
}
