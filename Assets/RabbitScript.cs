using UnityEngine;
using System.Collections;
using DG.Tweening;
using System.Diagnostics;

public class RabbitScript : MonoBehaviour
{

	//private Animator animator;
	//public float CurrentHP = 100;
	//private float HitCounter = 0;
	//private float MinimumHitPeriod = 1f;

	// Use this for initialization
	void Start()
	{
		//animator = this.GetComponent<Animator>();
	}
	void Update()
	{
		//if (CurrentHP > 0 && HitCounter > 0)
		//{
		//	HitCounter -= Time.deltaTime;
		//}
		//else
		//{
		//	if (CurrentHP > 0 && HitCounter > 0)
		//	{

		//		animator.SetBool("attack", true);
				
				
		//	}
		//	else
		//	{
		//		animator.SetBool("attack", true);
		//	}
		//}



	}

	//public void Hit(float value)
	//{
	//	if (HitCounter <= 0)
	//	{
	//		HitCounter = MinimumHitPeriod;
	//		CurrentHP -= value;

	//		animator.SetFloat("HP", CurrentHP);
	//		animator.SetTrigger("Hit");

	//		if (CurrentHP <= 0) { BuryTheBody(); }
	//	}
	//}
	//void BuryTheBody()
	//{
	//	this.GetComponent<Rigidbody>().useGravity = false;
	//	this.GetComponent<Collider>().enabled = false;
	//	this.transform.DOMoveY(-0.8f, 1f).SetRelative(true).SetDelay(1).OnComplete(() =>
	//	{
	//		this.transform.DOMoveY(-0.8f, 1f).SetRelative(true).SetDelay(3).OnComplete(() =>
	//		{
	//			GameObject.Destroy(this.gameObject);
	//		});
	//	});
	//}
}
