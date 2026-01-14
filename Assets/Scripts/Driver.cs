using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float baseSpeed = 5f;
    [SerializeField] float baseSteer = 5f;

    void Update() {
        PlayerControl();
    }

    void PlayerControl()
    {
        float move = 0f;
        float steer = 0f;
        float moveAmount = 0f;
        float steerAmount = 0f;

        // len xuong
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            move = 1f;
        }
        else if(Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            move = -1f;
        }

        // trai phai
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            steer = 1f;
        }
        else if(Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            steer = -1f;
        }


        moveAmount = move * baseSpeed * Time.deltaTime;
        steerAmount = steer * baseSteer * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, steerAmount);
    }

}
