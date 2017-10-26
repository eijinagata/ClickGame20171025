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
        if (other.gameObject.tag == "Ground")
        {
            GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log("判定おけ");
            Destroy(this.gameObject);
        }
    }
    void Start () {

       
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
