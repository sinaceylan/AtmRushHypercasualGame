using UnityEngine;

public class Movement: MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float horSpeed;
    float hor;

    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(movementSpeed * Time.deltaTime, hor * horSpeed * Time.deltaTime, 0));
    }
}