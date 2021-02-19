using UnityEngine;

public class AnimationCode : MonoBehaviour
{
	private Animator _animator;
    

	void Start()
	{
		_animator = GetComponent<Animator>();
	}

	public void Andar()
	{
		 _animator.SetBool("IsWalking", true);
	}

	public void PararDeAndar()
	{
		_animator.SetBool("IsWalking", false);
	}

	public void Pular()
	{
		_animator.SetTrigger("pulando");
	}

	public void PararDePular()
	{
		_animator.ResetTrigger("pulando");
	}
}