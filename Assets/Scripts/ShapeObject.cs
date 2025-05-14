using System;
using UnityEngine;

/*ShapeObject es el script o componente que tendrán nuestros GameObjects
que harán que nuestro personaje cambie de Forma o Sprite. También
tendrán un Evento para notificar el cambio de forma o Sprite en el
momento que detectan una colisión con el jugador*/

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
