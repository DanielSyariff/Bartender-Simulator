using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Bartender/Ingredient")]
public class IngredientData : ScriptableObject
{
    public string ingredientName;
    [TextArea] public string ingredientDesc;
}
