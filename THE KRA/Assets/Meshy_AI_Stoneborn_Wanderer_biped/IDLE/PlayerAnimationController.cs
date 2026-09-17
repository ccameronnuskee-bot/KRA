using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    void Update()
    {
        bool isMoving =
            Keyboard.current != null &&
            (Keyboard.current.wKey.isPressed ||
             Keyboard.current.aKey.isPressed ||
             Keyboard.current.sKey.isPressed ||
             Keyboard.current.dKey.isPressed);

        bool isSprinting =
            isMoving &&
            Keyboard.current != null &&
            Keyboard.current.leftShiftKey.isPressed;

        animator.SetFloat("Speed", isMoving ? 1f : 0f);
        animator.SetBool("IsSprinting", isSprinting);
    if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
{
animator.SetTrigger("Attack");
}
}
}