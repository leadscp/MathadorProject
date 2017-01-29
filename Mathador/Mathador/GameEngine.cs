using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Mathador
{
    class GameEngine
    {
        public const String pattern = @"([0-9]+)([\/\+\-\*])([0-9]+)";

        // Constructeur du GameEngine
        public GameEngine()
        {
        }

        // Détecte l'opérateur selon le regExp et fait opération 
        // Retour le nombre de points selon l'opérateur
        public List<int> doOperation(String operation)
        {
            Regex r = new Regex(pattern);
            Match m = r.Match(operation);

            String operateur = Convert.ToString(m.Groups[2].Value);
            int number1 = Convert.ToInt32(m.Groups[1].Value);
            int number2 = Convert.ToInt32(m.Groups[3].Value);
            List<int> resultOperationAndPoints = new List<int>();
            int points = 0;

            switch (operateur)
            {
                case "+":
                    points = 1;
                    resultOperationAndPoints.Add(number1 + number2);
                    resultOperationAndPoints.Add(points);
                    return resultOperationAndPoints;

                case "-":
                    points = 2;
                    resultOperationAndPoints.Add(number1 - number2);
                    resultOperationAndPoints.Add(points);
                    return resultOperationAndPoints;

                case "/":
                    int result = number1 % number2;
                    points = 3;

                    // Si le résultat est inférieur à 1, alors on renvoie  -1 pour afficher une erreur
                    if (result != 0)
                    {
                        result = -1;
                        points = 0;
                    }
                    else
                    {
                        result = number1 / number2;
                    }

                    resultOperationAndPoints.Add(result);
                    resultOperationAndPoints.Add(points);
                    return resultOperationAndPoints;

                case "*":
                    points = 1;
                    resultOperationAndPoints.Add(number1 * number2);
                    resultOperationAndPoints.Add(points);
                    return resultOperationAndPoints;

                default:
                    return resultOperationAndPoints;
            }
        }
    }
}
