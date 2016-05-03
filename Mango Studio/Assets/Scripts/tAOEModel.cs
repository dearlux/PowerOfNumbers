using UnityEngine;
using System.Collections;
namespace Tutorial{
public class tAOEModel : MonoBehaviour {

	private tAOE owner;			// Pointer toa the parent object.
	public Material mat;
	private float clock;

	public void init(tAOE owner) {
		this.owner = owner;

		transform.parent = owner.transform;					// Set the model's parent to the gem.
		transform.localPosition = new Vector3(0,0,0);		// Center the model on the parent.
		name = "Boss Model";									// Name the object.

		mat = GetComponent<Renderer>().material;		
		mat.shader = Shader.Find ("Sprites/Default");						// Tell the renderer that our textures have transparency. // Get the material component of this quad object.
		mat.mainTexture = Resources.Load<Texture2D>("Textures/Boss2AOE");	// Set the texture.  Must be in Resources folder.
		clock = 0;
	}
	
	// Update is called once per frame
	void Update () {
		mat.color = new Color(0 + Mathf.Sin(clock*2),1,1);
		clock = clock + Time.deltaTime;
	}
}
}