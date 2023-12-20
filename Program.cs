using algo_avance;
using System;

/* Une résolution du problème du sac à dos*/
/* MEMBRES DU GROUPE:
 * - VONJINIAINA Josoa N°3 ESIIA 3
 * - RAZAFINDRAKOTO Koloina Nirina Nathalie N°6 ESIIA 3
 * - ANDRIAMASINORO Aina Maminirina N°24 ESIIA 3
 * - RAFALIMANANA Minosoa Mampionona N°61 IGGLIA 3
 * - RAHELIMALALA Anja Nasandratra N°62 IGGLIA 3 	
 */
namespace algo_avance;
class Program
{
    public static void Main()
    {
        int[] profit = new int[] { 60, 100, 120 };
        int[] weight = new int[] { 10, 20, 30 };
        int W = 50;
        int n = profit.Length;
        // 1 - Comparaison des noms des différentes variables utilisées dans le code
        // par rapport à ceux dans nos cours:
        /*
         * profit représente la valeur V(n)
         * weight représente le poids P(n)
         * W représente la capacité K
         * n représente l'objet O(n)
         */

        //2 - Implémentation en C# avec l'application du POO ()
        //Création d'une instance pour la classe Knapsack
        Knapsack k = new Knapsack();

        //Affichage de la capacité maximale du sac à dos
        Console.WriteLine("Programmation Dynamique - Problème du sac à dos ");
        Console.WriteLine("Capacité max du sac à dos: " + k.knapSack(W, weight, profit, n));

        // 3 - Implémentation du parcours inverse permettant de détailler les objets à emporter (Class Reverse)
        Console.WriteLine("");
        SacADosSolver solver = new SacADosSolver(W, weight, profit);
        int resultat = solver.Resoudre();
        Console.WriteLine("La valeur maximale obtenue est : " + resultat);

        solver.AfficherMat();


        // 4 - Modification du code sur le traitements des problèmes dans le cas où le poids des objets ne sont
        // pas des entiers, mais des réels: le syntaxe doit comme suit " float weight ; " 
        // Affichage: Console.WriteLine(weight, 0.2);
    }
}
// Code fait aujourd'hui 150923