using System;

namespace _17._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(name:"Gunel",surname:"Hasanova",age:19,group:"p127",point:100,isGraduated:true);
            Console.WriteLine(student.AllAbout("Gunel","Hasanova",19,"P127",100,));
            
        }
    }
    class Student
    {
        public string name ;
        public string surname;
        public byte age;
        public string group;
        public byte point;
        public bool isGraduated;

        public Student(string name,string surname,byte age,string group,byte point,bool isGraduated)
        {
            name =name;
            surname = surname;
            age = age;
            group = group;
            point = point;
            isGraduated = isGraduated;
        }

        public  string FullName()
        {
            return name + " " + surname;
        }
        public string AllAbout()
        {
            return $"name:{name}/n surname:{surname}/n age:{age}/n group:{group}/n point:{point}/n isGraduated:{isGraduated}";
            if (isGraduated)
            {
                Console.WriteLine("Bu telebe mezun olub");
            }
            else
            {
                Console.WriteLine("Bu telebe mezun olmayib");
            }
          
        }
        public  void TakeExam()
        {
            if (point>80)
            {
                Console.WriteLine("Imtahana yeniden buraxilir");
            }
            else
            {
                Console.WriteLine("Imtahana buraxilmir");
            }
            
        }
    }
    
}
