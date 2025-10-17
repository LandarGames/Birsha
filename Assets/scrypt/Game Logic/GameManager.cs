using System;
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

   

    public Action NewPrices;

    private void Start()
    {
        PriceKrokens = UnityEngine.Random.Range(1, 100);
        PriceDobner = UnityEngine.Random.Range(1, 100);
        PriceUkht = UnityEngine.Random.Range(1, 100);
        NewKoafK();
        NewKoafD();
        NewKoafU();
        NewPrices.Invoke();
       

    }

    private void NewKoafK()
    {
        KoafK = UnityEngine.Random.Range(0f, 1f);
        PriceKrokens = (int)(KoafK * PriceKrokens);
        Invoke(nameof(NewKoafK), _baseValues[0].TimeUpdate);
        NewPrices.Invoke();
    }

    private void NewKoafD()
    {
        KoafD = UnityEngine.Random.Range(0f, 1f);
        PriceDobner = (int)(KoafD * PriceDobner);
    
        Invoke(nameof(NewKoafD), _baseValues[1].TimeUpdate);
        NewPrices.Invoke();
    }

    private void NewKoafU()
    {
        KoafU = UnityEngine.Random.Range(0f, 1f);
        PriceUkht = (int)(KoafU * PriceUkht);
        Invoke(nameof(NewKoafU), _baseValues[2].TimeUpdate);
        NewPrices.Invoke();
    }



}
