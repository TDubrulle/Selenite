using UnityEngine;
using System.Collections;

public class Joueur : MonoBehaviour {

    EntiteMouvements mouvements;

	// Use this for initialization
	void Awake () {
        mouvements = new EntiteMouvements(this.transform);
	}
	
	// Update is called once per frame
	void Update () {
        mouvements.UpdatePosition();
	}
}
