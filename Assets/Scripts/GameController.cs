using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform cubeTransform;

    private void Awake()
    {
        Debug.Log("GameController Awake Called");
        ServiceLocator.RegisterService<IMovementService>(new CubeMovementService(cubeTransform));
        ServiceLocator.RegisterService<IScoreService>(new ScoreService());
        ServiceLocator.RegisterService<IAudioService>(new AudioService());
    }
}