using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class logic : MonoBehaviour {
	public int int_gold = 0;
	public int int_action = 0;
	public int int_buy = 0;
	public int int_score = 0;

// Gold logic
	public void ClickedMinusGold() {
		int_gold = int_gold - 1;
		if (int_gold < 0) {
			int_gold = 0;
		}
		GetComponent<Text>().text = int_gold.ToString();
	}
	public void ClickedAddGold() {;
		int_gold = int_gold + 1;
		GetComponent<Text>().text = int_gold.ToString();
	}

// Buy logic
	public void ClickedMinusBuy() {
		int_buy = int_buy - 1;
		if (int_buy < 0) {
			int_buy = 0;
		}
		GetComponent<Text>().text = int_buy.ToString();
	}
	public void ClickedAddBuy() {;
		int_buy = int_buy + 1;
		GetComponent<Text>().text = int_buy.ToString();
	}

// Action logic
	public void ClickedMinusAction() {
		int_action = int_action - 1;
		if (int_action < 0) {
			int_action = 0;
		}
		GetComponent<Text>().text = int_action.ToString();
	}
	public void ClickedAddAction() {;
		int_action = int_action + 1;
		GetComponent<Text>().text = int_action.ToString();
	}

// Score Logic
	public void ClickedMinusScore() {
		int_score = int_score - 1;
		GetComponent<Text>().text = int_score.ToString();
	}
	public void ClickedAddScore() {;
		int_score = int_score + 1;
		GetComponent<Text>().text = int_score.ToString();
	}
}
