using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Krobens;
    public int Dobner;
    public int Ukht;

    public float Money;

    [SerializeField] private TextMeshProUGUI _howK;
    [SerializeField] private TextMeshProUGUI _howD;
    [SerializeField] private TextMeshProUGUI _howU;
    [SerializeField] private TextMeshProUGUI _textMoney;

    [SerializeField] private TextMeshProUGUI _consoleText;
    [SerializeField] private Transform _pos;


    [SerializeField] private GameManager _gm;

    private void Start()
    {
        UpdateInfoHow();
    }

    public void Koup(int id)
    {
        switch (id)
        {
            case 0:
                if (Krobens > 0)
                {
                    Money += _gm.PriceKrokens;
                    Krobens -= 1;
                    TextMeshProUGUI text = Instantiate(_consoleText, _pos.transform.position, Quaternion.identity, _pos);
                    text.text = $"продано {_gm._baseValues[0].Name} за {_gm.PriceKrokens}";
                }
                break;
            case 1:
                if (Dobner > 0)
                {
                    Money += _gm.PriceDobner;
                    Dobner -= 1;
                    TextMeshProUGUI text = Instantiate(_consoleText, _pos.transform.position, Quaternion.identity, _pos);
                    text.text = $"продано {_gm._baseValues[1].Name} за {_gm.PriceDobner}";
                }
                break;
            case 2:
                if (Ukht > 0)
                {
                    Ukht -= 1;
                    Money += _gm.PriceUkht;
                    TextMeshProUGUI text = Instantiate(_consoleText, _pos.transform.position, Quaternion.identity, _pos);
                    text.text = $"продано {_gm._baseValues[2].Name} за {_gm.PriceUkht}";
                }
                break;
        }
        UpdateInfoHow();
    }

    public void Bought(int id)
    {
        switch (id)
        {
            case 0:
                if (_gm.PriceKrokens <= Money)
                {
                    Money -= _gm.PriceKrokens;
                    Krobens += 1;
                    TextMeshProUGUI text = Instantiate(_consoleText, _pos.transform.position, Quaternion.identity, _pos);
                    text.text = $"куплено {_gm._baseValues[0].Name} за {_gm.PriceKrokens}";
                }
                break;
            case 1:
                if (_gm.PriceDobner <= Money)
                {
                    Money -= _gm.PriceDobner;
                    Dobner += 1;
                    TextMeshProUGUI text = Instantiate(_consoleText, _pos.transform.position, Quaternion.identity, _pos);
                    text.text = $"куплено {_gm._baseValues[1].Name} за {_gm.PriceDobner}";
                }
                break;
            case 2:
                if (_gm.PriceUkht <= Money)
                {
                    Ukht += 1;
                    Money -= _gm.PriceUkht;
                    TextMeshProUGUI text = Instantiate(_consoleText, _pos.transform.position, Quaternion.identity, _pos);
                    text.text = $"куплено {_gm._baseValues[2].Name} за {_gm.PriceUkht}";
                }
                break;
        }
        UpdateInfoHow();
    }

    private void UpdateInfoHow()
    {
        _howD.text = $"{Dobner}";
        _howK.text = $"{Krobens}";
        _howU.text = $"{Ukht}";
        _textMoney.text = $"{Money}$";
    }


}
