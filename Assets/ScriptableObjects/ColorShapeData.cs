using UnityEngine;

/*ColorShapeData es un Scriptable Object que puede almacenar un Color y
un Sprite. Este SO se utilizará para configurar nuestros otros objetos en la
escena y guardar información de nuestro jugador*/

[CreateAssetMenu(fileName = "Color Shape Data", menuName = "Scriptable objects/ Game 1/ColorShapeData")]
public class ColorShapeData : ScriptableObject
{
    public Color color;
    public Sprite sprite;
}
