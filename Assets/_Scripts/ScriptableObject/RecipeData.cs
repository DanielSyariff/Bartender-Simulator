using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class IngredientComposition
{
    public IngredientData ingredient;
    public int dosing;
}

[Serializable]
public class AdditionalComposition
{
    public IngredientData ingredient;
    public int qty;
}

[CreateAssetMenu(fileName = "Recipe", menuName = "Bartender/Recipe")]
public class RecipeData : ScriptableObject
{
    public string recipeName;
    [TextArea] public string recipeDesc;
    public List<IngredientComposition> ingredientComposition;
    public List<AdditionalComposition> additionalComposition;
}
