using UnityEngine;
using System.Collections;

public class UiAnimation : MonoBehaviour {

	public void DisableBoolAnimator(Animator anim)
	{
		anim.SetBool ("IsDisplayed", false);
	}
	public void EnableBoolAnimator(Animator anim)
	{
		anim.SetBool ("IsDisplayed", true);
	}

	public void DisableBoolAnimator1(Animator anim)
	{
		anim.SetBool ("IsDisplayed1", false);
	}
	public void EnableBoolAnimator1(Animator anim)
	{
		anim.SetBool ("IsDisplayed1", true);
	}
}
