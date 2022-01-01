using System;
using System.Collections.Generic;

namespace c_sharp_odev_list
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numberList = new List<int>();
            numberList.Add(10);
            numberList.Add(15);
            numberList.Add(11);
            numberList.Add(5);


            List<string> colorList = new List<string>();
            colorList.Add("Green");
            colorList.Add("Blue");
            colorList.Add("Orange");


            //Count
            Console.WriteLine(numberList.Count);
            Console.WriteLine(colorList.Count);


            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }
            foreach (var item in colorList)
            {
                Console.WriteLine(item);
            }


            numberList.ForEach(num => Console.WriteLine(num));
            colorList.ForEach(color => Console.WriteLine(color));


            numberList.Remove(11);
            colorList.Remove("Blue");


            numberList.RemoveAt(0);

            numberList.ForEach(num => Console.WriteLine(num));
            colorList.ForEach(color => Console.WriteLine(color));


            if (numberList.Contains(15))
            {
                Console.WriteLine("Have 15");
            }


            Console.WriteLine(colorList.BinarySearch("Orange"));



            string[] animals = { "Cat", "Dog", "Bird" };
            List<string> animalList = new List<string>(animals);

            animalList.Clear();



            List<User> userList = new List<User>();

            User user1 = new User();
            user1.FirstName = "John";
            user1.LastName = "Doe";
            user1.Age = 20;

            User user2 = new User();
            user2.FirstName = "Bilbo";
            user2.LastName = "Baggins";
            user2.Age = 30;


            userList.Add(user1);
            userList.Add(user2);


            List<User> newUserList = new List<User>();

            newUserList.Add(new User()
            {
                FirstName = "Frodo",
                LastName = "Baggins",
                Age = 20
            });

            newUserList.Clear();







        }




        public class User
        {
            private string firstName;
            private string lastName;
            private int age;

            public string FirstName { get => firstName; set => firstName = value; }
            public string LastName { get => lastName; set => lastName = value; }
            public int Age { get => age; set => age = value; }
        }









    }
}
