using System;
namespace UT1_3
{
    /* Class: Program
     * Author: Jonathan Karcher
     * Purpose: Create a delegate to impersonate the console readline 
     */
    class Program
    {
        // create a delegate function
        delegate string impersonate();
        /* Method: Main
         * Purpose: Assign and use the delegate function
         * Restrinctions: None
         */ 
        static void Main(string[] args)
        {
            // assign the delegate to the impersonate function
            impersonate i = new impersonate(Impersonate);
            // use the delegated variable
            i();
        }
        /* Method: Impersonate
         * Purpose: Return the console readline function
         * Restrinctions: None
         */
        static string Impersonate()
        {
            // return the console readline function
            return Console.ReadLine();
        }
    }
}