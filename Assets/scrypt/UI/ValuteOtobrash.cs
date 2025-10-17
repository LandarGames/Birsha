using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ValuteOtobrash : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] _textNames;
    [SerializeField] private TextMeshProUGUI[] _textNamesPlayer;
    [SerializeField] private TextMeshProUGUI[] _textValues;
    [SerializeField] private TextMeshProUGUI[] _textPlayer;
    [SerializeField] private TextMeshProUGUI _textMoney;

    [SerializeField] private Image[] _icon;
    [SerializeField] private Image[] _iconPlayer;
    [SerializeField] private Player _player;


    [SerializeField] private TextMeshProUGUI _consoleText;
    [SerializeField] private Transform _pos;

    public BaseValute[] _baseValues;

    [SerializeField] private GameManager _gm;
    private void Awake()
    {
        _gm.NewPrices += NewInfo;
        _player.NewPlayerInfo += PlayerInfo;
        _textPlayer[1].text = $"{_player.Dobner}";
        _textPlayer[0].text = $"{_player.Krobens}";
        _textPlayer[2].text = $"{_player.Ukht}";
        _textMoney.text = $"{_player.Money}$";
    }

    private void NewInfo()
    {
        for (int i = 0; i < _baseValues.Length; i++)
        {
            _textNames[i].text = _baseValues[i].Name.ToString();
            _textNamesPlayer[i].text = _baseValues[i].Name.ToString();
            _icon[i].sprite = _baseValues[i]._sprite;
            _iconPlayer[i].sprite = _baseValues[i]._sprite;
        }
        _textValues[0].text = $"{_gm.PriceKrokens}$";
        _textValues[1].text = $"{_gm.PriceDobner}$";
        _textValues[2].text = $"{_gm.PriceUkht}$";
        
    }

    private void PlayerInfo(int id)
    {
        switch (id)
        {
            case 0:
                TextMeshProUGUI text = Instantiate(_consoleText, _pos.transform.position, Quaternion.identity, _pos);
                text.text = $"продано {_gm._baseValues[0].Name} за {_gm.PriceKrokens}";
                break;
            case 1:
                TextMeshProUGUI texts = Instantiate(_consoleText, _pos.transform.position, Quaternion.identity, _pos);
                texts.text = $"продано {_gm._baseValues[0].Name} за {_gm.PriceKrokens}";
                break;
            case 2:
                TextMeshProUGUI textss = Instantiate(_consoleText, _pos.transform.position, Quaternion.identity, _pos);
                textss.text = $"продано {_gm._baseValues[0].Name} за {_gm.PriceKrokens}";
                break;
        }
        _textPlayer[1].text = $"{_player.Dobner}";
        _textPlayer[0].text = $"{_player.Krobens}";
        _textPlayer[2].text = $"{_player.Ukht}";
        _textMoney.text = $"{_player.Money}$";
    }
}
