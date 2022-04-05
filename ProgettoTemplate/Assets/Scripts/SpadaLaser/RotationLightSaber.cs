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

    void RotateSaber()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.AddForce(transform.forward * 75f);
        rigidbody.AddTorque(transform.right * 100f);

        /*
        Quaternion deltaRotation = Quaternion.Euler(angleVelocity * 1000f);
        rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
        */
    }

    public IEnumerator RotationSaber()
    {
        count = true;

        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.up * 500f);
        rigidbody.AddTorque(transform.right * 5000f);

        yield return new WaitForSeconds(3f);

        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        this.transform.eulerAngles = new Vector3(90, 0, 0);

        var positionHand = GameObject.Find("RightBaseController");

        this.transform.position = positionHand.transform.position;

        yield return new WaitForSeconds(5f);

        count = false;

    }

    public void GetRotationSaber()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.up * 500f);
        rigidbody.AddTorque(transform.right * 5000f);


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
