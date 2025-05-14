using UnityEngine;
using UnityEngine.UI;

/*Color Panel es el Script de la UI para mostrar el color del jugador
actualmente*/

public class ColorPanel : MonoBehaviour
{
    [SerializeField] private Image ColorImage;
    private void OnEnable()
    {
        ColorObject.OnChangeColor += UpdateColor;
    }

    private void OnDisable()
    {
        ColorObject.OnChangeColor -= UpdateColor;
    }

    private void UpdateColor(Color newColor)
    {
        ColorImage.color = newColor;
    }

}
