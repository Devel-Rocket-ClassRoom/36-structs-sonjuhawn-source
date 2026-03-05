using System;
using System.Numerics;

// README.md를 읽고 코드를 작성하세요.

Ingredient[] ingredient1 = new Ingredient[4];
ingredient1[0] = new Ingredient("스파게티면", 200, "g");
ingredient1[1] = new Ingredient("토마토소스", 150, "ml");
ingredient1[2] = new Ingredient("양파", 1, "개");
ingredient1[3] = new Ingredient("마늘", 3, "쪽");

RecipeCard recipe = new RecipeCard("토마토 파스타", 2, ingredient1);
Console.WriteLine("=== 원본 레시피 ===");
recipe.PrintRecipe();

recipe = recipe.ScaleRecipe(4);
Console.WriteLine("=== 4인분으로 변환 ===");
recipe.PrintRecipe();

struct Ingredient
{
    public string Name;
    public double Amount;
    public string Unit;

    public Ingredient(string name, double amount, string unit)
    {
        Name = name;
        Amount = amount;
        Unit = unit;
    }
}

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings,  Ingredient[] ingredient)
    {
        Name = name;
        Servings = servings;
        Ingredients = ingredient;
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine($"재료: ");
        for(int i = 0; i < Ingredients.Length; i++)
        {
            Console.WriteLine($"-{Ingredients[i].Name}: {Ingredients[i].Amount}{Ingredients[i].Unit}");
        }
    }

    public RecipeCard ScaleRecipe(int newServings)
    {
        double scale = 0;
        scale = newServings / (double)Servings;
        Servings = newServings;
        for(int i = 0;i < Ingredients.Length; i++)
        {
            Ingredients[i].Amount *= scale;
        }

        return this;
    }
}