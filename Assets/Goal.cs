using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent ( typeof(Renderer) )]
public class Goal : MonoBehaviour
{   
    // A static field accessible by code anywhere
    static public bool goalMet = false;

    void OnTriggerEnter( Collider other ) {
        // When the trigger is hit vy something
        // Check to see if it's a Projectile
        Projectile proj = other.GetComponent<Projectile>();
        if ( proj != null ) {
            // if so, set goalMet to true
            Goal.goalMet = true;
            // Also set the alpha of the color to higher opacity
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 0.75f;
            mat.color = c;
        }
    }
    
}
