using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour {

	void Start () {
	}
	// Update is called once per frame
	void Update () {
		//メインカメラ位置を基準にアイテムを削除
		GameObject maincamera = GameObject.FindWithTag("MainCamera");
		if (this.transform.position.z < maincamera.transform.position.z) {
			Destroy (this.gameObject);
		}
	}
}