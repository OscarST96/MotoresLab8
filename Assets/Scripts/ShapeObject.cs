using System;
using UnityEngine;

/*ShapeObject es el script o componente que tendr�n nuestros GameObjects
que har�n que nuestro personaje cambie de Forma o Sprite. Tambi�n
tendr�n un Evento para notificar el cambio de forma o Sprite en el
momento que detectan una colisi�n con el jugador*/

public class ShapeObject : MonoBehaviour
{
    [SerializeField]private ColorShapeData shapeData;
    private SpriteRenderer spriteRenderer;

    public static event Action<Sprite> OnChangeShape;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetUp();
    }
    private void SetUp()
    {
        spriteRenderer.sprite = shapeData.sprite;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnChangeShape?.Invoke(shapeData.sprite);
        }
    }
}
