using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteController : MonoBehaviour {

	//unitycahn
	public GameObject unitychan;

	// Use this for initialization
	void Start () {

		//unitychanの情報を取得
		this.unitychan = GameObject.Find("unitychan");
		
	}
	
	// Update is called once per frame
	void Update () {
		

		if (this.gameObject.transform.position.z < this.unitychan.transform.position.z){
			Destroy (this.gameObject,0.2f);
		}
	}
}