using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JogadorButton : MonoBehaviour
{
    private Jogador jogador;
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        Initialize();   
    }

    private void Initialize()
    {
        jogador = GetComponent<Jogador>();
        _text.text = "$" + jogador._jogador.Dinheiros + " " + jogador._jogador.Nome.ToString();
    }
}
