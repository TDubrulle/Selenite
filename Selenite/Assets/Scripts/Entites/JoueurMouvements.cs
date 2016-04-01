using UnityEngine;
using System.Collections;
using System;

public class JoueurMouvements : EntiteMouvements
{
    public JoueurControleur entreesJoueur;
    public float vitesseMouvementX;
    public float puissanceSaut;

    public JoueurMouvements(Transform entiteTransform, JoueurControleur jc) : base(entiteTransform) {
        acceleration.x = 0.0f;
        entreesJoueur = jc;
    }
    
    public JoueurMouvements(Transform entiteTransform, float accelerationX) : base(entiteTransform){
        acceleration.x = accelerationX;
    }
    
    protected override void calculerAcceleration() {
        acceleration.x += entreesJoueur.getMouvementX();
        acceleration.y += entreesJoueur.getMouvementY() - gravite;
    }

    protected override void calculerCollisions() {
        
    }

    /**Calcule l'accélération sur l'axe horizontal (x)
    * @return float la nouvelle accélération horizontale
    */
    protected float calculerAccelerationX() {
        return acceleration.x;
    }
    /**Calcule l'accélération sur l'axe vertical (y)
    * @return float la nouvelle accélération verticale.
    */
    protected float calculerAccelerationY() {
        return acceleration.y;
    }

}
