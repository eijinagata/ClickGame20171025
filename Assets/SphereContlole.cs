using UnityEngine;
using System.Collections;

public class SphereContlole : MonoBehaviour {

	// Use this for initialization
    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
