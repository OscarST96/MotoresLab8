using UnityEngine;

/*PlayerColorShapeController es el Script o Componente del jugador que
cambiará el color y forma de nuestro personaje conforme recibamos la
notificación respectiva*/

public class PlayerColorShapeController : MonoBehaviour
{
    [SerializeField] private ColorShapeData playerData;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetUp();
    }
    private void OnEnable()
    {
        ColorObject.OnChangeColor += UpdateColor;
        ShapeObject.OnChangeShape += UpdateShape;
    }
    private void OnDisable()
    {
        ColorObject.OnChangeColor -= UpdateColor;
        ShapeObject.OnChangeShape -= UpdateShape;
    }
    public void SetUp()
    {
        if (playerData != null)
        {
            spriteRenderer.color = playerData.color;
            spriteRenderer.sprite = playerData.sprite;
        }
    }
    private void UpdateColor(Color newColor)
    {
        playerData.color = newColor;
        spriteRenderer.color = newColor;
    }
    private void UpdateShape(Sprite newSprite)
    {
        playerData.sprite = newSprite;
        spriteRenderer.sprite = newSprite;
    }
}
