using UnityEngine;

public class CubeMovementService : IMovementService
{
    private Transform _cubeTransform;
    
    public CubeMovementService(Transform cubeTransform)
    {
        _cubeTransform = cubeTransform;
    }

    public void Move(Vector3 direction)
    {
        _cubeTransform.Translate(direction * Time.deltaTime);
    }
}