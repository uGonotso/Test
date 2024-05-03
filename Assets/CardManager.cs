using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class CardManager : MonoBehaviour
{
    public static CardManager Instance;
    public Text hpText;
    public Text powerText;
    public Text specialText;
    public Text nameText;
    public Text selectedCardsText;
    public Button nextButton;
    public string player; 
    private List<string> selectedCards = new List<string>();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void UpdateCardStats(Card card)
    {
        hpText.text = "HP: " + card.hp;
        powerText.text = "Power: " + card.power;
        specialText.text = "Special Attack: " + card.special;
        nameText.text = "Card Name: " + card.cardtype;

        if (!selectedCards.Contains(card.cardtype))
        {
            selectedCards.Add(card.cardtype);
        }
        if (selectedCards.Count > 3)
        {
            selectedCards.RemoveAt(0);
        }

        nextButton.interactable = (selectedCards.Count == 3);
        selectedCardsText.text = "Selected Cards: " + string.Join(", ", selectedCards);
    }

public void OnNextButtonClicked()
    {
        Debug.Log("Going to Next Scene!");

        // Store the selected cards in the GameManager
        if (player == "P1")
        {
            GameManager.Instance.p1selectedCards = new List<string>();
            foreach (string card in selectedCards)
            {
                GameManager.Instance.p1selectedCards.Add("p1" + card);
            }
        }
        else if (player == "P2")
        {
            GameManager.Instance.p2selectedCards = new List<string>();
            foreach (string card in selectedCards)
            {
                GameManager.Instance.p2selectedCards.Add("p2" + card);
            }
        }

        // Start a coroutine to delay the scene change
        StartCoroutine(DelayedSceneChange());
    }

private IEnumerator DelayedSceneChange()
    {
        // Wait for a few seconds
        yield return new WaitForSeconds(1);

        // Determine which scene to load based on the player variable
        string sceneToLoad = (player == "P1") ? "P2CardSelect" : "Game";
        SceneManager.LoadScene(sceneToLoad);
    }
}