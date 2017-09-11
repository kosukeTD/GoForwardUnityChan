using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControllerKadai: MonoBehaviour {
	
	//キューブの移動速度
	private float speed = -0.2f;

	//消滅位置
	private float deadline = -10;


	//地面の位置
	//private float groundLevel = -3.0f;

	//private AudioSource = GetComponent<AudioSource>();


	//課題
	//接触の対象
	private GameObject unitychan;
	private GameObject cube;
	private GameObject ground;

	AudioSource audio;

	// Use this for initialization
	void Start () {


		audio = GetComponent<AudioSource> ();
		//AudioSource audio = GetComponent<AudioSource> ();



		//課題
		//接触の対象を探す
		this.unitychan = GameObject.Find ("UnityChan2D");
		this.cube = GameObject.Find ("CubePrefab");
		this.ground = GameObject.Find ("Ground");



		//this.audio = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		//キューブを移動させる
		transform.Translate (this.speed,0,0);

		//画面外に出たら破棄する
		if (transform.position.x < this.deadline) {
			Destroy (gameObject);
		}


		//キューブ接地しているかどうかを調べる
		//bool 〜〜( 条件 )? false : true → 条件を満たしたら　「 A : B 」　Aとなる。この場合は「false」
		//bool isCube = (transform.position.y > this.groundLevel) ? false : true;
		//this.audio.SetBool ("isGround", isGround);

		//課題
		//bool isCube = (transform.position.y > this.groundLevel) ? false : true;
		//this.audio.SetBool ("isCube", isCube);

		
	}


	void OnCollisionEnter2D(Collision2D coll){
		//キューブと当たった場合、音をならす
		if(coll.gameObject.tag == "TagCube"){
			audio.Play();
		}
		if(coll.gameObject.tag == "TagGround"){
			audio.Play();
		}
	
	
	}


}
