using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHighlight : MonoBehaviour {

    // Reference to Sprite Renderer component
    private Renderer rend;

    // Color value that we can set it Inspector
    // It's White by default
    [SerializeField]
    private Color colorToTurnTo = Color.white;

    // Use this for Initialization
    private void Start()
    {

        // Assign Sprite Renderer Component to rend variable
        rend = GetComponent<Renderer>();

        // Change sprite color to selected color
        rend.material.color = colorToTurnTo;
    }
}
