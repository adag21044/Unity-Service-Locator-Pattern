using UnityEngine;

public class ScoreService : IScoreService
{
    private int _score;
    
    public void IncreaseScore(int amount)
    {
        _score += amount;
        Debug.Log($"Score: {_score}");
    }

    public int GetScore()
    {
        return _score;
    }
}