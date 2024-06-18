using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorMove : MonoBehaviour
{
    public  Rigidbody ActorDody = null;
    void Start()
    {
        
    }

    public enum E_DirectionType
    {
        Up = 0, Down, Left, Right
    }

    [SerializeField]
    protected E_DirectionType m_DirectionType = E_DirectionType.Up;
    protected void SetActorMove(E_DirectionType p_moveType)
    {
        Vector3 offsetpos = Vector3.zero;

        switch (p_moveType)
        {
            case E_DirectionType.Up:
                offsetpos = Vector3.up;
                break;
            case E_DirectionType.Down:
                offsetpos = Vector3.down;
                break;
            case E_DirectionType.Left:
                offsetpos = Vector3.left;
                break;
            case E_DirectionType.Right:
                offsetpos = Vector3.right;
                break;
            default:
                Debug.LogErrorFormat("SetActorMove Error : {0}", p_moveType);
                break;
        }
        this.transform.position += offsetpos;
    } 

    void Update()
    {
        Vector3 offsetpos = Vector3.zero;
    }
}
