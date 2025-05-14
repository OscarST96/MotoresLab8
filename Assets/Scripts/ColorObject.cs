using System;
using UnityEngine;

/*ColorObject es el script o componente que tendr�n nuestros GameObjects
que har�n que nuestro personaje cambie de Color. Tambi�n tendr�n un
Evento para notificar el cambio de color en el momento que detectan una
colisi�n con el jugador*/

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
