using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour {

	private int _lives = 3;
	public int _Points;

	public Text pointsValue;
	public Text livesValue; 

	public GameObject gameOverSign;
	public GameObject youWinSign; 


	public void SetLives(int newvalue){
		_lives = newvalue; 
		Debug.Log ("lives now equal:" + _lives); 
		livesValue.text = _lives.ToString ();

		if (_lives == 0) 
		{
			DoGameOver ();
		}

	}

	public int GetLives()
	{
		return _lives;

	}

	public void SetPoints (int newValue)
	{
		_Points = newValue;
		pointsValue.text = _Points.ToString ();

		var coinsLeft = FindObjectsOfType <Coin> ().Length;
		Debug.Log ("coinsleft: " +coinsLeft);

		if (coinsLeft == 0) 
		{
			DoYouWin ();
		}
	}

	public int GetPoints ()
	{
		return _Points;
	}


	void DoGameOver()
	{
		gameOverSign.SetActive (true);
	}

	void DoYouWin ()
	{
		youWinSign.SetActive(true); 

	}


}