using UnityEngine;
using System.Collections;
using System ;
public class ConvertType : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Transform ss = this.transform;
		string name = ss.GetType ().ToString ();
		string name1 = ss.GetType ().Name;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
