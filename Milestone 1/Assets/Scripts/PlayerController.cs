using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    protected Animator _animator;
    public Animator Animator
    {
        get { return _animator; }
        protected set { _animator = value; }
    }

    public float Forward = 0f;

    // Use this for initialization
    void Start()
    {
        if (!_animator)
        {
            _animator = GetComponentInChildren<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.anyKey)
        {
            if (Input.GetKey(KeyCode.W))
            {
                Forward = 0.5f;
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    Forward = 1f;
                }
                
                _animator.SetFloat("forward", Forward);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _animator.SetTrigger("jump");
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                _animator.SetTrigger("left_attack");
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                _animator.SetTrigger("center_combo");
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                _animator.SetTrigger("right_attack");
            }

        } else
        {
            Forward = 0f;
            _animator.SetFloat("forward", Forward);
        }
    }
}
