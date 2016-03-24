using UnityEngine;
using System.Collections;

/**Classe représentant les possibilités mouvementalistes d'une entité.*/
public class EntiteMouvements {

    /**Gravité vers le bas. Commune à toutes les entités.*/
    public static float gravite = 0.5f;

    public Vector2 vitesse;

    protected Vector2 vitesseCourante;

    public Transform entiteTransform;

    // Use this for initialization
    public EntiteMouvements(Transform entite) {
        vitesseCourante = new Vector2();
        entiteTransform = entite;
	}
	
    /**Met à jour la position de l'entité.*/
	public void UpdatePosition() {
        vitesseCourante = (vitesseCourante + Vector2.down) * 0.25f;
        
        //Si on rentre en collision avec un objet, on se place juste à l'extrémité de celui-ci.
        //TTODO
        entiteTransform.position += new Vector3(vitesseCourante.x, vitesseCourante.y, entiteTransform.position.z);
    }
}
