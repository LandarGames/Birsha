using System;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Krobens;
    public int Dobner;
    public int Ukht;

    public float Money;

  

   


    [SerializeField] private GameManager _gm;

    public Action<int> NewPlayerInfo;

    

    public void Koup(int id)
    {
        switch (id)
        {
            case 0:
                if (Krobens > 0)
                {
                    Money += _gm.PriceKrokens;
                    Krobens -= 1;
                   
                }
                break;
            case 1:
                if (Dobner > 0)
                {
                    Money += _gm.PriceDobner;
                    Dobner -= 1;
                }
                break;
            case 2:
                if (Ukht > 0)
                {
                    Ukht -= 1;
                    Money += _gm.PriceUkht;
                }
                break;
        }
        NewPlayerInfo.Invoke(id);
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
                    
                }
                break;
            case 1:
                if (_gm.PriceDobner <= Money)
                {
                    Money -= _gm.PriceDobner;
                    Dobner += 1;
                   
                }
                break;
            case 2:
                if (_gm.PriceUkht <= Money)
                {
                    Ukht += 1;
                    Money -= _gm.PriceUkht;
                    
                }
                break;
        }
        NewPlayerInfo.Invoke(id);
    }



}
