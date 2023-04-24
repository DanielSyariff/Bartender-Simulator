using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Customer", menuName = "Bartender/Customer")]
public class CustomerData : ScriptableObject
{
    public string customerName;
    [TextArea] public string customerDesc;
    public RecipeData recipeData;
}
