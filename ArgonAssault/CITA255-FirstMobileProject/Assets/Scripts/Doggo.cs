using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Doggo : MonoBehaviour
{
    [SerializeField] SpriteRenderer dogSprite;
    [SerializeField] TextMeshProUGUI dogText;

    public DogBreed dogBreed; //allow access to the enum in unity. this allows the script to be set to a given dog breed

    public enum DogBreed { //Set custom classes to use in switch case
        AustralianShepherd,
        Beagle,
        BorderCollie,
        ChowChow,
        Corgi,
        GoldenRetriever,
        LabradorRetriever,
        Maltipoo,
        ShetlandSheepDog
    }
    public void updateDogInfo()
    {
        switch (dogBreed) //switch logic based on dog breed chosen
        {
            case DogBreed.AustralianShepherd:
                dogText.text = "Australian Shepherd\nGood doggo";
                dogSprite.sprite = Resources.Load<Sprite>("australian"); //Load the australian sprite from the Resources folder in Unity editor
                break;
            case DogBreed.Beagle:
                dogText.text = "Beagle\nGood doggo";
                dogSprite.sprite = Resources.Load<Sprite>("beagle");
                break;
            case DogBreed.BorderCollie:
                dogText.text = "Border Collie\nGood doggo";
                dogSprite.sprite = Resources.Load<Sprite>("border");
                break;
            case DogBreed.ChowChow:
                dogText.text = "Chow Chow\nGood doggo";
                dogSprite.sprite = Resources.Load<Sprite>("chow");
                break;
            case DogBreed.Corgi:
                dogText.text = "corgi\nGood doggo";
                dogSprite.sprite = Resources.Load<Sprite>("corgi");
                break;
            case DogBreed.GoldenRetriever:
                dogText.text = "Golden Retriever\nGood doggo";
                dogSprite.sprite = Resources.Load<Sprite>("golden");
                break;
            case DogBreed.LabradorRetriever:
                dogText.text = "Labrador Retriever\nGood doggo";
                dogSprite.sprite = Resources.Load<Sprite>("labrador");
                break;
            case DogBreed.Maltipoo:
                dogText.text = "Maltipoo\nGood doggo";
                dogSprite.sprite = Resources.Load<Sprite>("maltipoo");
                break;
            case DogBreed.ShetlandSheepDog:
                dogText.text = "Shetland Sheep\nGood doggo";
                dogSprite.sprite = Resources.Load<Sprite>("shetland");
                break;
            default:
                Debug.Log("No doggo breed recognized");
                break;
        }
    }

    private void Start()
    {
        updateDogInfo();
    }
}
