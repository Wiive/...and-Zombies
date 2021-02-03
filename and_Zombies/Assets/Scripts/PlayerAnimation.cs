using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LookDirection
{
    up = 0,
    left,
    right,
    down,
}

public enum PlayerState
{
    idle = 0,
    walking,
}

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private PlayerState playerState;
    [SerializeField] private LookDirection lookDirection;

    [SerializeField] private float xAxis;
    [SerializeField] private float yAxis;

    private SpriteRenderer playerRenderer;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        playerState = PlayerState.idle;
        lookDirection = LookDirection.down;
        playerRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        CheckMovement();        
    }

    public void CheckMovement()
    {
        if (yAxis > 0)
        {
            lookDirection = LookDirection.up;
        }
        else if (yAxis < 0)
        {
            lookDirection = LookDirection.down;
        }
        else if (xAxis < 0)
        {
            lookDirection = LookDirection.left;
        }
        else if (xAxis > 0)
        {
            lookDirection = LookDirection.right;
        }
        anim.SetFloat("LookDir", (float)lookDirection);
        anim.SetInteger("Playerstate", (int)playerState);
    }

    public void SetAnimPlayerState(PlayerState state)
    {
        playerState = state;
        anim.SetInteger("Playerstate", (int)playerState);
    }

    public LookDirection GetDirection()
    {
        return lookDirection;
    }
}
