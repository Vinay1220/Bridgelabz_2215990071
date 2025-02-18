using System;
using System.Collections.Generic;

// Interface for meal plans
public interface IMealPlan
{
    string GetMealType();
}

// Specific meal types
public class VegetarianMeal : IMealPlan
{
    public string GetMealType()
    {
        return "Vegetarian Meal";
    }
}

public class VeganMeal : IMealPlan
{
    public string GetMealType()
    {
        return "Vegan Meal";
    }
}

public class KetoMeal : IMealPlan
{
    public string GetMealType()
    {
        return "Keto Meal";
    }
}

public class HighProteinMeal : IMealPlan
{
    public string GetMealType()
    {
        return "High-Protein Meal";
    }
}

// Generic Meal class restricted to IMealPlan types
public class Meal<T> where T : IMealPlan, new()
{
    public string MealName { get; private set; }
    public T MealCategory { get; private set; }

    public Meal(string mealName)
    {
        MealName = mealName;
        MealCategory = new T();
    }

    public override string ToString()
    {
        return "Meal: " + MealName + " | Type: " + MealCategory.GetMealType();
    }
}

// Meal Plan Generator
public class MealPlanGenerator
{
    public static void GenerateMealPlan<T>(List<Meal<T>> meals) where T : IMealPlan, new()
    {
        if (meals == null || meals.Count == 0)
        {
            Console.WriteLine("No meals available.");
            return;
        }

        foreach (var meal in meals)
        {
            Console.WriteLine(meal);
        }
    }
}

// Testing the implementation
class Program
{
    static void Main()
    {
        List<Meal<VegetarianMeal>> vegetarianMeals = new List<Meal<VegetarianMeal>>
        {
            new Meal<VegetarianMeal>("Vegetable Stir Fry"),
            new Meal<VegetarianMeal>("Lentil Soup")
        };

        List<Meal<VeganMeal>> veganMeals = new List<Meal<VeganMeal>>
        {
            new Meal<VeganMeal>("Tofu Salad"),
            new Meal<VeganMeal>("Vegan Pasta")
        };

        Console.WriteLine("Vegetarian Meal Plan:");
        MealPlanGenerator.GenerateMealPlan(vegetarianMeals);

        Console.WriteLine("\nVegan Meal Plan:");
        MealPlanGenerator.GenerateMealPlan(veganMeals);
    }
}