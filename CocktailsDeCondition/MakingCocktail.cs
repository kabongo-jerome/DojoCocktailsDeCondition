using System.Collections.Generic;

namespace CocktailsDeCondition
{
    public class MakingCocktail
    {
        public string GetNameCocktail(List<string> ingredients)
        {
            var recipe = DetectIngredients(ingredients);
            if (recipe[Ingredient.Beer])
            {
                return GetNameCocktailWithBeer(recipe);
            }

            return recipe[Ingredient.Vodka] ? GetNameCocktailWithVodka(recipe) : Cocktails.Beer;
        }

        private string GetNameCocktailWithVodka(Dictionary<string, bool> recipe)
        {
            if (recipe[Ingredient.Tequila])
            {
                return GetNameCocktailWithVodkaAndTequila(recipe);
            }

            if (recipe[Ingredient.Fruit] && recipe[Ingredient.SodaWater])
            {
                return Cocktails.MarinesVodka;
            }

            return recipe[Ingredient.Gin] ? Cocktails.VodkaCoffins : Cocktails.Vodka;
        }

        private string GetNameCocktailWithVodkaAndTequila(Dictionary<string, bool> recipe)
        {
            if (recipe[Ingredient.Gin])
            {
                return recipe[Ingredient.Fruit] ? Cocktails.LongIsland : Cocktails.TGV;
            }

            return Cocktails.BlueShark;
        }

        private string GetNameCocktailWithBeer(Dictionary<string, bool> recipe)
        {
            if (recipe[Ingredient.SodaWater])
            {
                return recipe[Ingredient.Fruit] ? Cocktails.Monaco : Cocktails.Panache;
            }

            if (recipe[Ingredient.Vodka])
            {
                return recipe[Ingredient.Fruit] ? Cocktails.SkollFruitz : Cocktails.Skoll;
            }

            return recipe[Ingredient.Tequila] ? Cocktails.Desperados : Cocktails.Beer;
        }

        private static Dictionary<string, bool> DetectIngredients(List<string> ingredients)
        {
            var recipe = new Dictionary<string, bool>
            {
                {Ingredient.Beer, false},
                {Ingredient.Vodka, false},
                {Ingredient.Tequila, false},
                {Ingredient.Fruit, false},
                {Ingredient.SodaWater, false},
                {Ingredient.Gin, false}
            };

            foreach (var ingredient in ingredients)
            {
                if (ingredient == Ingredient.Beer)
                {
                    recipe[Ingredient.Beer] = true;
                    continue;
                }
                if (ingredient == Ingredient.Vodka)
                {
                    recipe[Ingredient.Vodka] = true;
                    continue;
                }
                if (ingredient == Ingredient.Tequila)
                {
                    recipe[Ingredient.Tequila] = true;
                    continue;
                }
                if (ingredient == Ingredient.Fruit)
                {
                    recipe[Ingredient.Fruit] = true;
                    continue;
                }
                if (ingredient == Ingredient.SodaWater)
                {
                    recipe[Ingredient.SodaWater] = true;
                    continue;
                }
                if (ingredient == Ingredient.Gin)
                {
                    recipe[Ingredient.Gin] = true;
                }
            }
            return recipe;
        }
    }
}