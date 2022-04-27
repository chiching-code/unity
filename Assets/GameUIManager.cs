using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{

	public Image BlackCover;
	public Image BloodBlur;
	public Text HPText;
	public Text TxtCoin;
	// Use this for initialization
	void Start()
	{
		BlackCover.color = Color.black;
		DOTween.To(() => BlackCover.color, (x) => BlackCover.color = x, new Color(0, 0, 0, 0), 1f);
		//GameObject goTxtCoin = GameObject.Find("TxtCoin");
		//if (goTxtCoin)
		//{
		//	txtCoin = goTxtCoin.GetComponent<Text>();
		//}
	}

	Tweener tweenAnimation;

	public void PlayHitAnimation()
	{
		if (tweenAnimation != null)
			tweenAnimation.Kill();

		BloodBlur.color = Color.white;
		tweenAnimation = DOTween.To(() => BloodBlur.color, (x) => BloodBlur.color = x, new Color(1, 1, 1, 0), 0.5f);

	}

	public void PlayerDiedAnimation()
	{
		BloodBlur.color = Color.white;
		DOTween.To(() => BlackCover.color, (x) => BlackCover.color = x, new Color(0, 0, 0, 1), 1f).SetDelay(3).
		OnComplete (() =>
		{
			DOTween.To(() => BloodBlur.color,
			(x) => BloodBlur.color = x,
				new Color(1, 1, 1, 0), 0.5f).SetDelay(3).OnComplete(() =>
				{
					SceneManager.LoadScene("PrewScene");
				});
		});
	}

	public void SetHP(int hp)
	{
		HPText.text = "HP:" + hp;
	}
	public void SetCoin(int coinNum)
	{
		TxtCoin.text = "Coin:" + coinNum;//num.ToString();
	}
}
