using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLightSaber : MonoBehaviour
{
    Vector3 angleVelocity;

    bool count;
    // Start is called before the first frame update
    void Start()
    {
        //angleVelocity = new Vector3(90, 0, 0);
        count = false;
    }

    // Update is called once per frame
    void Update()
    {
        // RotateSaber();
       
    }

    public void GetRotationSaber()
    {
        var rigidbody = GetComponent<Rigidbody>();
        if (rigidbody.velocity.magnitude > 1)
        {
            rigidbody.AddForce(transform.up * 500f);
            rigidbody.AddTorque(transform.right * 5000f);

            Invoke("ReturnToHand", 3f);
        }



    }

    public void ReturnToHand()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        this.transform.eulerAngles = new Vector3(90, 0, 0);

        var positionHand = GameObject.Find("RightBaseController");

        this.transform.position = positionHand.transform.position;
    }
}
