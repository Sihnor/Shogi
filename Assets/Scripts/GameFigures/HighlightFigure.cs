using System;
using UnityEngine;

namespace GameFigures
{
    public class HighlightFigure : MonoBehaviour
    {
        private Color DefaultColor;

        private void Awake()
        {
            Renderer renderer = GetComponent<Renderer>();
            this.DefaultColor = renderer.material.color;
        }

        private void OnMouseEnter()
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.color = Color.grey;
        }

        private void OnMouseExit()
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.color = this.DefaultColor;
        }
    }
}