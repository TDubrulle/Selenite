using UnityEngine;
using System.Collections;

public class Joueur : MonoBehaviour {

    /**Les mouvements du joueur.*/
    protected EntiteMouvements mouvements;

    /**Le contrôleur permettant de déplacer le joueur*/
    public JoueurControleur controleur;

	// Use this for initialization
	void Awake () {
        mouvements = new JoueurMouvements(this.transform, controleur);

	}
	
	// Update is called once per frame
	void Update () {
        mouvements.updatePosition();
	}
}
