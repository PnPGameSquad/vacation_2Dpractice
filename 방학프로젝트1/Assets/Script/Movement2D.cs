using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float movespeed = 5.0f; // 이동 속도
    private Vector3 moveDirection;

    public void Setup(Vector3 direction)
    {
        moveDirection = direction;
    }
    private void Update()
    {
        transform.position += moveDirection * movespeed * Time.deltaTime;
    }
}
