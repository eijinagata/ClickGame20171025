using UnityEngine;
using System.Collections;

public class SphereContlole : MonoBehaviour {

    bool DliatFlag = false;
	// Use this for initialization
    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision other)//アタッチされたゲームオブジェクトが何かにぶつかった際の判定。
    {
        if (other.gameObject.tag == "Ground")//もし衝突した対象がGroundのタグを持つオブジェクトだった場合。
        {
            GetComponent<Rigidbody>().isKinematic = true;
            DliatFlag = true;
            Debug.Log("判定おけ");
            //Destroy(this.gameObject);
        }
    }
    void Start () {

       
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            if(DliatFlag==true)
            {
                Destroy(this.gameObject);
                DliatFlag = false;
            }
        }

	}
}
