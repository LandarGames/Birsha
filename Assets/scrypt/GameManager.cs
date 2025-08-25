using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float PriceKrokens;
    public float PriceDobner;
    public float PriceUkht;

    public float KoafK;
    public float KoafD;
    public float KoafU;

    public BaseValute[] _baseValues;

    [SerializeField] private TextMeshProUGUI[] _textNames;
    [SerializeField] private TextMeshProUGUI[] _textNamesPlayer;
    [SerializeField] private TextMeshProUGUI[] _textValues;

    [SerializeField] private Image[] _icon;
    [SerializeField] private Image[] _iconPlayer;

    private void Start()
    {
        PriceKrokens = Random.Range(1, 100);
        PriceDobner = Random.Range(1, 100);
        PriceUkht = Random.Range(1, 100);
        NewKoafK();
        NewKoafD();
        NewKoafU();
        for (int i = 0;i <_baseValues.Length;i++)
        {
            _textNames[i].text = _baseValues[i].Name.ToString();
            _textNamesPlayer[i].text = _baseValues[i].Name.ToString();
            _icon[i].sprite = _baseValues[i]._sprite;
            _iconPlayer[i].sprite = _baseValues[i]._sprite;
        }
        _textValues[0].text = $"{PriceKrokens}$";
        _textValues[1].text = $"{PriceDobner}$";
        _textValues[2].text = $"{PriceUkht}$";

    }

    private void NewKoafK()
    {
        KoafK = Random.Range(0f, 1f);
        PriceKrokens = (int)(KoafK * PriceKrokens);
        _textValues[0].text = $"{PriceKrokens}$";
        Invoke(nameof(NewKoafK), _baseValues[0].TimeUpdate);
    }

    private void NewKoafD()
    {
        KoafD = Random.Range(0f, 1f);
        PriceDobner = (int)(KoafD * PriceDobner);
        _textValues[1].text = $"{PriceDobner}$";
        Invoke(nameof(NewKoafD), _baseValues[1].TimeUpdate);
    }

    private void NewKoafU()
    {
        KoafU = Random.Range(0f, 1f);
        PriceUkht = (int)(KoafU * PriceUkht);
        _textValues[2].text = $"{PriceUkht}$";
        Invoke(nameof(NewKoafU), _baseValues[2].TimeUpdate);
    }



}
