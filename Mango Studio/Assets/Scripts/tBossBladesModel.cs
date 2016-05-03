using UnityEngine;
using System.Collections;

namespace Tutorial{
public class tBossBladesModel : MonoBehaviour {

	private tBossBlades owner;			// Pointer to the parent object.
	public Material mat;

	public void init(tBossBlades owner) {
		this.owner = owner;

		transform.parent = owner.transform;					// Set the model's parent to the gem.
		transform.localPosition = new Vector3(0,0,0);		// Center the model on the parent.
		name = "BossBlades Model";									// Name the object.

		mat = GetComponent<Renderer>().material;		
		mat.shader = Shader.Find ("Sprites/Default");						// Tell the renderer that our textures have transparency. // Get the material component of this quad object.
		mat.mainTexture = Resources.Load<Texture2D>("Textures/bossBlades");	// Set the texture.  Must be in Resources folder.
		mat.color = new Color(1,1,1);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
}