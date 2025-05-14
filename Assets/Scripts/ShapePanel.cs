using UnityEngine;
using UnityEngine.UI;

/*Shape Panel es el Script de la UI para mostrar el Sprite del jugador
actualmente*/

public class ShapePanel : MonoBehaviour
{
    [SerializeField] Image ShapeImage;
    private void OnEnable()
    {
        ShapeObject.OnChangeShape += UpdateShape;
    }

    private void OnDisable()
    {
        ShapeObject.OnChangeShape -= UpdateShape;
    }

    private void UpdateShape(Sprite newShape)
    {
        ShapeImage.sprite = newShape;
    }
}
