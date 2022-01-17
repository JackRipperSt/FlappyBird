using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMoover))]
public class Bird : MonoBehaviour
{
    private BirdMoover _moover;
    private int _score;

    public event UnityAction GameOver;
    public event UnityAction<int> ScoreChanged;

    private void Start()
    {
        _moover = GetComponent<BirdMoover>();
       
    }

    public void IncreaseScore()
    {
        _score++;
        ScoreChanged?.Invoke(_score);
    }




    public void ResetPlayer()
    {
        _score = 0;
        ScoreChanged(_score);
        _moover.ResetBird();
    }


    public void Die()
    {
        GameOver?.Invoke();

    }


}
