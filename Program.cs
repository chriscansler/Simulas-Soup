(Seasoning, Ingredients, Recipes) mySoup = GetMySoup();
DisplaySoup(mySoup);

// Local Functions (of the implicit Main() method);
(Seasoning, Ingredients, Recipes) GetMySoup() {
	Recipes recipe = GetRecipe();
	Ingredients ingredient = GetIngredient();
	Seasoning seasoning = GetSeasoning();
	return (seasoning, ingredient, recipe);
}

Recipes GetRecipe() {
	Console.Write("What kind of soup would you like (soup, stew, gumbo): ");
	string input = Console.ReadLine();
	return input switch {
		"soup" => Recipes.Soup,
		"stew" => Recipes.Stew,
		"gumbo" => Recipes.Gumbo
	};
}

Ingredients GetIngredient() {
	Console.Write("What main ingredient would you like (mushrooms, chicken, carrots, potatoes): ");
	string input = Console.ReadLine();
	return input switch {
		"mushrooms" => Ingredients.Mushrooms,
		"chicken" => Ingredients.Chicken,
		"carrots" => Ingredients.Carrots,
		"potatoes" => Ingredients.Potatoes
	};
}

Seasoning GetSeasoning() {
	Console.Write("What kind of seasoning would you like (spicy, salty, sweet): ");
	string input = Console.ReadLine();
	return input switch {
		"spicy" => Seasoning.Spicy,
		"salty" => Seasoning.Salty,
		"sweet" => Seasoning.Sweet,
	};
}

void TestMethod() {}

void TestMethod2() {}

void TestMethod3() {}

void DisplaySoup((Seasoning seasoning, Ingredients ingredient, Recipes recipe) soup) {
	Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.recipe}");
}

// Enumerations for all of Simula's soup combinations
// Enumerations for all of Simula's soup combinations
// Enumerations for all of Simula's soup combinations
// Enumerations for all of Simula's soup combinations
// Enumerations for all of Simula's soup combinations
enum Recipes { Soup = 1, Stew, Gumbo };
enum Ingredients { Mushrooms = 1, Chicken, Carrots, Potatoes };
enum Seasoning { Spicy = 1, Salty, Sweet };

/*

// explicit types
(string, string, string) soup = ("Sweet", "Chicken", "Gumbo");
Console.WriteLine(soup);

// var
var soup2 = ("Spicy", "Carrot", "Stew");
Console.WriteLine(soup2);

// Accessing items in the tuple
Console.WriteLine($"Seasoning: {soup2.Item1}, Ingredient: {soup2.Item2}, Recipe: {soup2.Item3}");

// better names than Item1, Item2, Item3, etc
(string Seasoning, string Ingredient, string Recipe) soup3 = ("Salty", "Potato", "Gumbo");
Console.WriteLine($"Seasoning: {soup3.Seasoning}, Ingredient: {soup3.Ingredient}, Recipe: {soup3.Recipe}");

// better names using var
var soup4 = (Seasoning: "Spicy", Ingredient: "Mushroom", Recipe: "Soup");
Console.WriteLine($"Seasoning: {soup4.Seasoning}; Ingredient: {soup4.Ingredient}; Recipe: {soup4.Recipe}");

// Passing the tuple into a method
DisplaySoup(soup4);
void DisplaySoup((string Seasoning, string Ingredient, string Recipe) soup) {
	Console.WriteLine($"Seasoning: {soup.Seasoning}; Ingredient: {soup.Ingredient}; Recipe: {soup.Recipe}");
}

// Getting a tuple from a method
(string Seasoning, string Ingredient, string Recipe) GetSoup() => ("Sweet", "Carrot", "Stew");
var soup5 = GetSoup();  // note that the tuple's types and names are inferred from the called method's return type
DisplaySoup(soup5);

// The tuple names don't have to match the return values of GetSoup()
(string S, string I, string R) soup6 = GetSoup();
Console.Write("soup6: ");
DisplaySoup(soup6);

// Deconstructing Tuples
var soup7 = (Seasoning: "Salty", Ingredient: "Mushroom", Recipe: "Gumbo");
(string s, string i, string r) = soup7;
Console.WriteLine($"soup7: {s} {i} {r}");

// Neat trick for swapping variables
double x = 4.0;
double y = 5.0;
(x, y) = (y, x);
Console.WriteLine($"x: {x}, y: {y}");

// Discards
var soup8 = (Seasoning: "Spicy", Ingredient: "Chicken", Recipe: "Stew");
(string ing, string rep, _) = soup8;
Console.WriteLine($"{ing} {rep}");

*/

/*
int userRecipeSelection = 1;
int userIngredientSelection = 1;
int userSeasoningSelection = 1;

Console.WriteLine($"1. {Recipes.Soup}");
Console.WriteLine($"2. {Recipes.Stew}");
Console.WriteLine($"3. {Recipes.Gumbo}");
Console.Write("What recipe would you like? ");

userRecipeSelection = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"1. {Ingredients.Mushrooms}");
Console.WriteLine($"2. {Ingredients.Chicken}");
Console.WriteLine($"3. {Ingredients.Carrots}");
Console.WriteLine($"3. {Ingredients.Potatoes}");

Console.Write("What main ingredient would you like? ");

userIngredientSelection = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"1. {Seasoning.Spicy}");
Console.WriteLine($"2. {Seasoning.Salty}");
Console.WriteLine($"3. {Seasoning.Sweet}");
Console.Write("What seasoning would you like? ");

userSeasoningSelection = Convert.ToInt32(Console.ReadLine());

var order = (
	Recipe: (Recipes)userRecipeSelection, 
	Ingredient: (Ingredients)userIngredientSelection, 
	Seasoning: (Seasoning)userSeasoningSelection
);

Console.WriteLine($"{order.Seasoning} {order.Ingredient} {order.Recipe}");



enum Recipes { Soup = 1, Stew, Gumbo };
enum Ingredients { Mushrooms = 1, Chicken, Carrots, Potatoes };
enum Seasoning { Spicy = 1, Salty, Sweet };
*/
