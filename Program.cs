using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes classes = new Classes();

            int Classand = 0;
            do
            {
                classes.andandandand(Classand);
                Classand++;
            } while (classes.lolololololol());

            classes.LolLolLol();
        }
    }
    class Student
    {
        public string name;
        public string ClassNum;
    }
    class Classes
    {
        Student[] students = new Student[99];

        public void andandandand(int StudetCount)
        {
            students[StudetCount] = new Student();

            System.Console.Write("이름 : ");
            students[StudetCount].name = System.Console.ReadLine();

            System.Console.Write("반 : ");
            students[StudetCount].ClassNum = System.Console.ReadLine();

            System.Console.WriteLine("-----------------");
        }
        public bool lolololololol()
        {
            System.Console.Write("계속 찾을까요?  (y/n) : ");
            string andloland = System.Console.ReadLine();

            if (andloland == "y" || andloland == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void LolLolLol()
        {
            System.Console.Write("찾고싶은 학생 이름을 입력해주세요 : ");
            string andloland = System.Console.ReadLine();

            for (int aanndd = 0; aanndd < students.Count(); aanndd++)
            {
                if (students[aanndd] == null)
                {
                    System.Console.WriteLine("못찾았습니다");
                    break;
                }

                else if (students[aanndd].ClassNum == andloland)
                {
                    System.Console.WriteLine($"이름 : {students[aanndd].name}");
                }
            }
        }
    }
}