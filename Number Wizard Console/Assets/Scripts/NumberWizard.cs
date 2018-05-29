using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
    int min = 1;
    int palpite = 500;

	// Use this for initialization
	void Start () 
	{
		StartGame();
	}

	void StartGame()
	{
		max = 1000;
		min = 1;
		palpite = 500;

		Debug.Log("Seja Bem-Vindo ao Number Wizard Console...");
        Debug.Log("Escolha um número, não me conte qual é...");
        Debug.Log("O valor escolhido deve estar entre " + min + " e " + max);
        Debug.Log("Diga me se o numero que você escolheu é maior ou menor que " + palpite + " ou se é o mesmo?");
        Debug.Log("Seta Acima = Maior, Seta Abaixo = Menor, Enter = Correto");
        max += 1;
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Debug.Log("Maior que:" + palpite);
			min = palpite;
			ProximoPalpite();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)) 
		{
			Debug.Log("Menor que:" + palpite);
			max = palpite;
			ProximoPalpite();
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("Correto este é meu número: " + palpite);
			StartGame();
		}
	}

	void ProximoPalpite()
	{
		palpite = (max + min) / 2;
		Debug.Log("Seu Número é: " + palpite + ", ou é maior ou menor que ele?");
	}
}
