using System.Diagnostics.CodeAnalysis;

namespace Assignment01OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            /* Class : 
             *      - Reference Type 
             *      - stored in heap with a reference in stack
             *      - inheritance is supported
             *      - best for complex content
             *      - parameterless constructors are made by compiler unless you made a parameter constructor
               Struct : 
                    - Value Type
                    - Stored in stack
                    - inheritance is not supported
                    - parameterless constructor is always made by compiler
                    - better when working with small data
            */
            //Person p;
            //p = new();
            //p.Name = "ahmed";
            //Person p2 = new Person();
            //p2 = p;
            //p2.Name = "Youssef";
            //Console.WriteLine(p.Name);//ahmed

            //Student person1 = new Student();
            //person1.Name = "Ali";
            //Student person2 = new Student();
            //person2 = person1;
            //person2.Name = "Mohamed";
            //Console.WriteLine(person1.Name);//Mohamed



            #endregion

            #region Question02
            /* if we make a private field inside a class we can not access it 
             * but if we have another field inside the same class with public access modifier
             * now we can see and access it */
            //Student student01 = new Student();
            //student01.age = 20;
            //student01.age2;  //error
            #endregion

            #region Question03
            /* create a new project and we choose class library not console application 
             * we have to make sure that our classes are public not internal
             * now we have to build this library to generate the .dll file 
             * we go to the project that we need to use this library in and on the dependencies 
               we right click and choose add project reference and then choose the .dll file of library
            */
            #endregion

            #region Question04
            /* class library is a separate project that contains reusable and frequently used classes
             * but has no main method and can not run on its own and it contains a .dll file */
            /* we use class librarires for organization , team work and reusability. you can think 
             * of it as a toolbox that contain tools (classes) you take this toolbox for each 
             * job(project) */
            #endregion
        }
    }
}
