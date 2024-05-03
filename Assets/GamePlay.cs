using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CanvasManager : MonoBehaviour
{
    // Card textures for player 1
    public Texture p1Shield;
    public Texture p1Dagger;
    public Texture p1Boot;
    public Texture p1Grim;
    public Texture p1Hand;

    // Card textures for player 2
    public Texture p2Shield;
    public Texture p2Dagger;
    public Texture p2Boot;
    public Texture p2Grim;
    public Texture p2Hand;

    // RawImage objects to display the selected cards
    public List<RawImage> p1SelectedImages;
    public List<RawImage> p2SelectedImages;

    // Text objects to display the total HP and PW
    public Text p1HpText;
    public Text p1PwText;
    public Text p2HpText;
    public Text p2PwText;

    void Start()
    {
        // Get the selected cards from the GameManager
        List<string> p1SelectedCards = GameManager.Instance.p1selectedCards;
        List<string> p2SelectedCards = GameManager.Instance.p2selectedCards;

        // Assign the images based on the selected cards
        for (int i = 0; i < p1SelectedCards.Count; i++)
        {
            p1SelectedImages[i].texture = GetCardTexture(p1SelectedCards[i], true);
        }

        for (int i = 0; i < p2SelectedCards.Count; i++)
        {
            p2SelectedImages[i].texture = GetCardTexture(p2SelectedCards[i], false);
        }

        // Calculate and display the total HP and PW
        p1HpText.text = "Total HP: " + CalculateTotalHp(p1SelectedCards, true);
        p1PwText.text = "Total PW: " + CalculateTotalPw(p1SelectedCards, true);
        p2HpText.text = "Total HP: " + CalculateTotalHp(p2SelectedCards, false);
        p2PwText.text = "Total PW: " + CalculateTotalPw(p2SelectedCards, false);
    }

    Texture GetCardTexture(string cardName, bool isPlayer1)
    {
        if (isPlayer1)
        {
            switch (cardName)
            {
                case "p1Shield":
                    return p1Shield;
                case "p1Dagger":
                    return p1Dagger;
                case "p1Boot":
                    return p1Boot;
                case "p1Grim":
                    return p1Grim;
                case "p1Hand":
                    return p1Hand;
                default:
                    return null;
            }
        }
        else
        {
            switch (cardName)
            {
                case "p2Shield":
                    return p2Shield;
                case "p2Dagger":
                    return p2Dagger;
                case "p2Boot":
                    return p2Boot;
                case "p2Grim":
                    return p2Grim;
                case "p2Hand":
                    return p2Hand;
                default:
                    return null;
            }
        }
    }

    int CalculateTotalHp(List<string> selectedCards, bool isPlayer1)
    {
        int totalHp = 0;
        foreach (string card in selectedCards)
        {
            if (isPlayer1)
            {
                switch (card)
                {
                    case "p1Shield":
                        totalHp += 7; // Placeholder value
                        break;
                    case "p1Dagger":
                        totalHp += 2; // Placeholder value
                        break;
                    case "p1Boot":
                        totalHp += 5; // Placeholder value
                        break;
                    case "p1Grim":
                        totalHp += 7; // Placeholder value
                        break;
                    case "p1Hand":
                        totalHp += 5; // Placeholder value
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (card)
                {
                    case "p2Shield":
                        totalHp += 7; // Placeholder value
                        break;
                    case "p2Dagger":
                        totalHp += 2; // Placeholder value
                        break;
                    case "p2Boot":
                        totalHp += 5; // Placeholder value
                        break;
                    case "p2Grim":
                        totalHp += 7; // Placeholder value
                        break;
                    case "p2Hand":
                        totalHp += 5; // Placeholder value
                        break;
                    default:
                        break;
                }
            }
        }
        return totalHp;
    }

    int CalculateTotalPw(List<string> selectedCards, bool isPlayer1)
    {
        int totalPw = 0;
        foreach (string card in selectedCards)
        {
            if (isPlayer1)
            {
                switch (card)
                {
                    case "p1Shield":
                        totalPw += 2; // Placeholder value
                        break;
                    case "p1Dagger":
                        totalPw += 7; // Placeholder value
                        break;
                    case "p1Boot":
                        totalPw += 5; // Placeholder value
                        break;
                    case "p1Grim":
                        totalPw += 8; // Placeholder value
                        break;
                    case "p1Hand":
                        totalPw += 3; // Placeholder value
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (card)
                {
                    case "p2Shield":
                        totalPw += 2; // Placeholder value
                        break;
                    case "p2Dagger":
                        totalPw += 7; // Placeholder value
                        break;
                    case "p2Boot":
                        totalPw += 5; // Placeholder value
                        break;
                    case "p2Grim":
                        totalPw += 8; // Placeholder value
                        break;
                    case "p2Hand":
                        totalPw += 3; // Placeholder value
                        break;
                    default:
                        break;
                }
            }
        }
        return totalPw;
    }
}
