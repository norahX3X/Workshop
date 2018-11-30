using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBG : MonoBehaviour {
	Material objectMaterial;
	Vector2 offset;
	public int Xv, Yv;
	public float wight;
	private void Awake () {
		objectMaterial = GetComponent<Renderer>().material;
	}
	// Use this for initialization
	void Start () {
		offset = new Vector2 (Xv, Yv);
	}
	
	// Update is called once per frame
	void Update () {
		objectMaterial.mainTextureOffset += offset * Time.deltaTime * wight ;
	}

}
