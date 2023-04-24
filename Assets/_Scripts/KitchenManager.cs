using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KitchenManager : MonoBehaviour
{
    public List<RecipeData> recipeData;
    public RecipeData orderResult;
    public CustomerOrderManager customerOrderManager;
    public List<IngredientComposition> mixer;

    [SerializeField] private int toCorrect;
    [SerializeField] private int correctCount;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StirUp();
        }
    }

    public void StirUp() //Cek Resep
    {
        Debug.Log("STIRRING");
        for (int i = 0; i < recipeData.Count; i++)
        {
            if (CompareLists(mixer, recipeData[i].ingredientComposition))
            {
                Debug.Log("LIST SAMA " + recipeData[i].recipeName);
                break;
            }
        }
    }
    public bool CompareLists(List<IngredientComposition> list1, List<IngredientComposition> list2)
    {
        if (list1 == null || list2 == null)
        {
            Debug.LogWarning("Salah satu List kosong.");
            return false;
        }

        if (list1.Count != list2.Count)
        {
            Debug.LogWarning("Jumlah elemen pada kedua List tidak sama.");
            return false;
        }

        
        for (int i = 0; i < list1.Count; i++)
        {
            //correctCount = 0;

            for (int j = 0; j < list2.Count; j++)
            {
                if (list1[i].ingredient != list2[j].ingredient)
                {
                    Debug.LogWarning("Elemen pada indeks [" + i + "] tidak sama. " + list1[i].ingredient + " " + list2[j].ingredient);
                }
                else
                {
                    Debug.LogWarning("Elemen pada indeks [" + i + "] sama. " + list1[i].ingredient + " " + list2[j].ingredient);
                    correctCount++;
                    Debug.Log(correctCount + "/" + list2.Count);
                    break;
                }
            }
        }

        if (correctCount == list2.Count)
        {
            Debug.Log("RESEP DITEMUKAN");
            correctCount = 0;
            return true;
        }
        else
        {
            Debug.Log("RESEP TIDAK DITEMUKAN");
            correctCount = 0;
            return false;
        }
        
    }

    public void CompareResult()
    {
        
    }

    public bool CompareMixer(int i, int j, int k)
    {
        if (mixer[i].ingredient == recipeData[j].ingredientComposition[k].ingredient &&
            mixer[i].dosing == recipeData[j].ingredientComposition[k].dosing)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}
