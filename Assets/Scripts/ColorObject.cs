using System;
using UnityEngine;

/*ColorObject es el script o componente que tendrán nuestros GameObjects
que harán que nuestro personaje cambie de Color. También tendrán un
Evento para notificar el cambio de color en el momento que detectan una
colisión con el jugador*/

public class ColorObject : MonoBehaviour
{
    [SerializeField]private ColorShapeData ColorData;
    private SpriteRenderer spriteRenderer;

    public static event Action<Color> OnChangeColor;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetUp();
    }
    private void SetUp()
    {
        spriteRenderer.color = ColorData.color;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnChangeColor?.Invoke(ColorData.color);
        }
    }
}
