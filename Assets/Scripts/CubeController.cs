using UnityEngine;

public class CubeController : MonoBehaviour
{
    private IMovementService _movementService;
    private IScoreService _scoreService;
    private IAudioService _audioService;

    private void Start()
    {
        Debug.Log("CubeController Start Called");
        _movementService = ServiceLocator.GetService<IMovementService>();
        _scoreService = ServiceLocator.GetService<IScoreService>();
        _audioService = ServiceLocator.GetService<IAudioService>();
    }

    private void Update()
    {
        Vector3 direction = Vector3.zero;

        if(Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }
        if(Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }
        if(Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        if(Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }

        if(direction != Vector3.zero)
        {
            _movementService.Move(direction);
            _audioService.PlaySound("Move");
            _scoreService.IncreaseScore(10);
        }
    }
}