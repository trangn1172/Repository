using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    [Tooltip("Health vaule between 0 and 100")]
    int health = 0;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 1f * horizontal * Time.deltaTime;
        position.y = position.y + 1f * vertical * Time.deltaTime;
        transform.position = position;
    }
}