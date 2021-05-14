using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Jogador", menuName = "Jogador")]
public class SJogador : ScriptableObject
{
    public IJogador JogadorTag;
    public ILane LaneJogador;
    public string Nome;
    public float Multiplicador;
    public float Dinheiros;
    public Sprite Foto;
}
