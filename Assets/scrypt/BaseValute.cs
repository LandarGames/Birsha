using UnityEngine;

[CreateAssetMenu(fileName = "Valute", menuName = "ValuteBase")]
public class BaseValute : ScriptableObject
{
    public string Name;
    public int Id;
    public float TimeUpdate;
    public Sprite _sprite;
}
