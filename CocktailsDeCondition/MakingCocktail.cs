using System.Collections.Generic;
using System.Linq;

namespace CocktailsDeCondition
{
    public class MakingCocktail
    {
        private static Dictionary<string, List<string>> recipes = new Dictionary<string, List<string>>()
        {
            { Cocktails.Beer, new List<string> { Ingredient.Beer }},
            { Cocktails.Vodka, new List<string> { Ingredient.Vodka }},
            { Cocktails.Skoll, new List<string> { Ingredient.Beer, Ingredient.Vodka }},
            { Cocktails.SkollFruitz, new List<string> { Ingredient.Beer, Ingredient.Vodka, Ingredient.Fruit }},
            { Cocktails.Desperados, new List<string> { Ingredient.Beer, Ingredient.Tequila }},
            { Cocktails.Monaco, new List<string> { Ingredient.Beer, Ingredient.Fruit, Ingredient.SodaWater }},
            { Cocktails.Panache, new List<string> { Ingredient.Beer, Ingredient.SodaWater }},
            { Cocktails.BlueShark, new List<string> { Ingredient.Vodka, Ingredient.Tequila }},
            { Cocktails.TGV, new List<string> { Ingredient.Vodka, Ingredient.Gin, Ingredient.Tequila }},
            { Cocktails.LongIsland, new List<string> { Ingredient.Vodka, Ingredient.Tequila, Ingredient.Gin, Ingredient.Fruit }},
            { Cocktails.VodkaCoffins, new List<string> { Ingredient.Vodka, Ingredient.Gin }},
            { Cocktails.MarinesVodka, new List<string> { Ingredient.Vodka, Ingredient.Fruit, Ingredient.SodaWater }},
        };

        public string GetNameCocktail(List<string> ingredients)
        {
            return recipes.FirstOrDefault(x => x.Value.OrderBy(t => t)
                                                .SequenceEqual(ingredients.OrderBy(t => t)))
                                                .Key;
        }
    }
}