using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Δημιουργώ και δηλώνω 2 μεταβλητές ακέραιου τύπου δεδομένου int.
            double num1;
            double num2;

            Console.WriteLine("Please insert the first number: ");  // Ζητάω από τον χρήστη να εισάγει τον πρώτο αριθμό.

            /* Διαβάζει το δεδομένο που έχει εισάγει ο χρήστης με το Console.ReadLine() 
            και προσπαθεί να το μετατρέψει σε ακέραιο αριθμό με την μέθοδο TryParse αποθηκεύοντας το αποτέλεσμα
            μέσω της λέξης κλειδί out στην μεταβλητή ενώ μέσω του τελεστή ! αντιστρέφεται το αποτέλεσμα και 
            παίρνοντας false μπαίνει μέσα στο σώμα της while και ζητάει ξανά είσοδο δεδομένων από τον χρήστη.
            Για όσο είναι true η επαναληπτική δομή τερματίζεται και η τιμή που έχει εισάγει ο χρήστης εκχωρείται στην μεταβλητή num1.
            */
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please insert numeric values only for the first number: ");
            }

            Console.WriteLine("Please insert the second number: ");  // Ζητάω από τον χρήστη να εισάγει τον δεύτερο αριθμό.
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please insert numeric values only for the second number: ");
            }

            Console.WriteLine("Please select which mathematical operation you want: ");
            Console.WriteLine("'A' => Addition");
            Console.WriteLine("'S' => Subtraction");
            Console.WriteLine("'D' => Division");
            Console.WriteLine("'M' => Multiplication");

            string operation = Console.ReadLine().ToUpper();    // Το δεδομένο που εισήγαγε ο χρήστης το μετατρέπω με την μέθοδο (ToUpper()) σε κεφαλαίο γράμμα.

            if (operation == "D")   // Εάν το γράμμα που δώσει ο χρήστης ισοδυναμεί με το "D" => άρα πρόκειται για το στάδιο της διαίρεσης.
            {
                while (num2 == 0)   // Για όσο παίρνω true από την συνθήκη και ο δεύτερος αριθμός ισοδυναμεί με το 0 εκτελείται το σώμα της while.
                {
                    Console.WriteLine("Division selected. The second number cannot be 0. Please insert a non-zero second number: ");   // Ζητάω από τον χρήστη να μού εισάγει ξανά τον δεύτερο αριθμό.
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Invalid input. Please insert numeric values only for the second number: ");
                    }
                }
            }

            // Καλώ την συναρτηση calculations με 3 ορίσματα (γράμμα διεξαγωγής μαθηματικής πράξης και 2 ακέραιοι αριθμοί).
            double result = Calculations(operation, num1, num2);   
            Console.WriteLine($"The result is {result}");      // Εκτύπωση αποτελέσματος στον χρήστη.

            double Calculations(string operation, double a, double b)   // Δημιουργία συνάρτησης με 3 ορίσματα (το γράμμα που έχει δόσει ο χρήστης και 2 αριθμοί).
            {
                switch (operation)  // Η δομή διακλάδωσης switch πραγματοποιείται με βάση το γράμμα που θα έχει εισάγει ο χρήστης.
                {
                    case "A":   // Σε περίπτωση που δοθεί το γράμμα 'A' επιστρέφεται κατευθείαν το αποτέλεσμα του αθροίσματος των 2 ακέραιων αριθμών.
                        return a + b;
                    case "S":
                        return a - b;
                    case "D":
                        return a / b;
                    case "M":
                        return a * b;
                }
                // Εάν ο χρήστης δεν επιλέξει τίποτα από τα παραπάνω ή πληκτρολογήσει κάποιο γράμμα με ελληνικούς χαρακτήρες τότε τυπώνεται στην κονσόλα (Invalid Operation) και επιστρέφεται η τιμή 0.
                Console.WriteLine("Invalid operation!");    
                return 0;
            }
            Console.ReadKey();
        }
    }

}
