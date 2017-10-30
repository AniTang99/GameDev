using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int min;
	int max;
	int guess;
	int maxGuessesAllowed = 10;
	
	public Text text;
	public Text guesses;
	
	public void Start () {
		StartGame ();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		NextGuess();
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	} 
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	
	void NextGuess () {
		guess = Random.Range(min,max+1);
		text.text = guess.ToString();
		guesses.text = "Guesses left: "+ maxGuessesAllowed.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0){
			Application.LoadLevel("Win");
		}
	}
}
