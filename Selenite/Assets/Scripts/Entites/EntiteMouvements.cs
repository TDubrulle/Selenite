using UnityEngine;
using System.Collections;

/**Classe représentant les possibilités mouvementalistes d'une entité.*/
public abstract class EntiteMouvements {

    /**Gravité vers le bas. Commune à toutes les entités.*/
    public static float gravite = 0.2f;

    /**Accélération de l'entité.*/
    protected Vector2 acceleration;
  
    /**La vitesse courante de l'entité.*/
    protected Vector2 vitesseCourante;

    /**La position de l'entité*/
    public Transform entiteTransform;

    public Vector2 getVitesseCourante() {
        return vitesseCourante;
    }

    /**Crée un nouveau mouvement en prenant en paramètre la position d'une entité.*/
    public EntiteMouvements(Transform entite) {
        vitesseCourante = new Vector2();
        acceleration = new Vector2();
        entiteTransform = entite;
	}

    /**Met à jour la position de l'entité.*/
    public void updatePosition() {
        calculerAcceleration();
        //Si on rentre en collision avec un objet, on se place juste à l'extrémité de celui-ci.
        calculerCollisions();
        entiteTransform.position += new Vector3(vitesseCourante.x, vitesseCourante.y, entiteTransform.position.z);
    }

    /**Calcule l'accélération globale, c'est à dire sur les deux axes. Elle ne met pas à jour les positions selon les collisions.*/
    abstract protected void calculerAcceleration();

    /**Calcule l'ensemble des collisions et met à jour l'accélération.*/
    abstract protected void calculerCollisions();
}