using static linq_demo_1.ListGenerator;
namespace linq_demo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            #region Q1
            // 1. LINQ - Restriction Operators

            // 1.1 Find all products that are out of stock
            var outOfStockProducts = ProductList.Where(p => p.UnitsInStock == 0);
            Console.WriteLine("Out of Stock Products:");
            foreach (var product in outOfStockProducts)
                Console.WriteLine(product);

            // 1.2 Find all products that are in stock and cost more than 3.00 per unit
            var inStockAndCostlyProducts = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            Console.WriteLine("\nIn Stock and Costly Products:");
            foreach (var product in inStockAndCostlyProducts)
                Console.WriteLine(product);

            // 1.3 Returns digits whose name is shorter than their value
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var shortNamedDigits = digits.Where((digit, index) => digit.Length < index);
            Console.WriteLine("\nDigits with Name Shorter than their Value:");
            foreach (var digit in shortNamedDigits)
                Console.WriteLine(digit);

            #endregion

            #region Q2
            // 2. LINQ - Ordering Operators

            // 2.1 Sort a list of products by name
            var sortedByName = ProductList.OrderBy(p => p.ProductName);
            Console.WriteLine("\nProducts Sorted by Name:");
            foreach (var product in sortedByName)
                Console.WriteLine(product);

            // 2.2 Uses a custom comparer to do a case-insensitive sort of the words in an array
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords = words.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine("\nWords Sorted Case-Insensitive:");
            foreach (var word in sortedWords)
                Console.WriteLine(word);

            // 2.3 Sort a list of products by units in stock from highest to lowest
            var sortedByStock = ProductList.OrderByDescending(p => p.UnitsInStock);
            Console.WriteLine("\nProducts Sorted by Units in Stock:");
            foreach (var product in sortedByStock)
                Console.WriteLine(product);

            // 2.4 Sort a list of digits, first by length of their name, and then alphabetically by the name itself
            var sortedDigits = digits.OrderBy(d => d.Length).ThenBy(d => d);
            Console.WriteLine("\nDigits Sorted by Length and Alphabetically:");
            foreach (var digit in sortedDigits)
                Console.WriteLine(digit);
            #endregion

            #region Q3
            // 3. LINQ – Transformation Operators

            // 3.1 Return a sequence of just the names of a list of products
            var productNames = ProductList.Select(p => p.ProductName);
            Console.WriteLine("\nProduct Names:");
            foreach (var name in productNames)
                Console.WriteLine(name);

            // 3.2 Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types)
            var upperLowerWords = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            Console.WriteLine("\nUppercase and Lowercase Words:");
            foreach (var word in upperLowerWords)
                Console.WriteLine($"Upper: {word.Upper}, Lower: {word.Lower}");

            // 3.3 Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type
            var productDetails = ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice, p.Category });
            Console.WriteLine("\nProduct Details (Name, Price, Category):");
            foreach (var product in productDetails)
                Console.WriteLine($"Name: {product.ProductName}, Price: {product.Price}, Category: {product.Category}");
            #endregion
        }
    }
}