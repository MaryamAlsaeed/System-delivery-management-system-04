namespace OOP_4
{
    internal class Program
    {
        #region Theoretical Questions
        /*
         * -----------Q1:-----------
         * a)  What is Abstraction in Object-Oriented Programming? 
         * - Abstraction is a process of hiding implementation details showing only essential features.
         * 
         * b)  Why is abstraction considered one of the four pillars of OOP?
         * - Because it hides implementation details showing only nessesary ones that the user needs.
         * - It makes the program reusable and maintanaible.
         * - Enables changing without breaking everything.
         * - Mainly focusing on the object behavior.
         * 
         * -----------Q2:-----------
         * 
         * a)  What is the difference between an Abstract Class and an Interface?
         * Abstract class: 
         * - Contains both abstract and concrete methods.
         * - Can be public and private fields.
         * - Abstract class cannot be instantiated.
         * - It can inherit from only one class.
         * - It can have constructors.
         * - Can provide shared implementation.
         * - It provides a (IS A) relationship. 
         * 
         * Interface:
         * - It is a contract that other classes can implement.
         * - Interfaces don't allow access modifiers.
         * - Cannot contain private fields.
         * - Classes can implement multiple interfaces.
         * - It cannot have constructors.
         * - It provides a (CAN DO) relationship.
         * 
         * b)  When would you choose an Interface instead of an Abstract Class? 
         * - Different, unrelated classes need to have the same behavior.
         * - You want a class to implement multiple behaviors.
         * - You don't need to share common fields or implementation.
         * 
         * c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
         * - No a class cannot inherit from multiple classes, even if they are abstract.
         * 
         */
        #endregion
        static void Main(string[] args)
        {
            
        }
    }
}
