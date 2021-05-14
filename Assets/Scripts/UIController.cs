using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _dinheiros;
    [SerializeField] private GameObject _jogadores;
    [SerializeField] private GameObject _melhorias;

    public void AtualizarDinheiros(double dinheiros)
    {
        _dinheiros.text = dinheiros + " Dinheiros";
    }

    public void InicializarDinheiros(double dinheiros)
    {
        AtualizarDinheiros(dinheiros);
    }

    public void AbrirJogadores()
    {
        _jogadores.SetActive(true);
        _melhorias.SetActive(false);
    }

    public void AbrirMelhorias()
    {
        _jogadores.SetActive(false);
        _melhorias.SetActive(true);
    }
}
