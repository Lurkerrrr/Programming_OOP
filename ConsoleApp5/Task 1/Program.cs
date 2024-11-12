using ConsoleApp5;
using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            B b1 = new B();
            B b2 = new B();
            C c1 = new C();
            C c2 = new C();

            List<A> listaA = new List<A>();
            AddToListA(listaA, a1, a2, b1, b2, c1, c2);

            List<B> listaB = new List<B>();
            AddToListB(listaB, b1, b2, c1, c2);

            List<C> listaC = new List<C>();
            AddToListC(listaC, c1, c2);

            Console.WriteLine("Iteracja po liście A:");
            foreach (A item in listaA)
            {
                item.Virtual();
                item.NotVirtual();
            }

            Console.WriteLine("\nIteracja po liście B:");
            foreach (B item in listaB)
            {
                item.Virtual();
                item.NotVirtual();
            }

            Console.WriteLine("\nIteracja po liście C:");
            foreach (C item in listaC)
            {
                item.Virtual();
                item.NotVirtual();
                item.methodCall(); 
            }

            static void AddToListA(List<A> listaA, A a1, A a2, B b1, B b2, C c1, C c2)
            {
                listaA.Add(a1);
                listaA.Add(a2);
                listaA.Add(b1);  
                listaA.Add(b2);  
                listaA.Add(c1);  
                listaA.Add(c2);  
            }

            static void AddToListB(List<B> listaB, B b1, B b2, C c1, C c2)
            {
                listaB.Add(b1);
                listaB.Add(b2);
                listaB.Add(c1);  
                listaB.Add(c2);  
            }

            static void AddToListC(List<C> listaC, C c1, C c2)
            {
                listaC.Add(c1);
                listaC.Add(c2);  
            }
        }
    }
}

//a) Które obiekty można umieścić na których listach? Umieścić obiekty na wszystkich listach na
//których się da.
//List<A>: Można umieścić obiekty klasy A, klasy B i klasy C, wszystkie te klasy dziedziczą po A.
//List<B>: Można umieścić obiekty klasy B oraz klasy C, klasa C dziedziczy po B.
//List<C>: Można umieścić tylko obiekty klasy C
//b) Czy możemy zawsze wykonać obie metody?
//Tak, bo sa wirtualne i njie wirtualne metody 
//c) Wykonanie metody z klasy A w metodzie klasy C (base.Metoda()) 
//Wywola z klassy A