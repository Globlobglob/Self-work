using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private int mark1;
        public int Mark1
        {
            get { return mark1 ; }
            set { mark1 = value; }
        }

        private int mark2 ;
        public int Mark2
        {
            get { return mark1; }
            set { mark2 = value; }
        }
        private int mark3;
        public int Mark3
        {
            get { return mark3; }
            set { mark3 = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

       // public int Id;
       public Student(int mark1,int mark2,int mark3)
       {
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
            
       }
        //public Student(int mark1,int mark2,int mark3) 
        //{
            
        //}


        private bool RangeMark(int mark)
        {
            return mark > 0 || mark < 5;
        }

        private int Avergage()
        {
            return (mark1 + mark2 + mark3) / 3;
        }

        private object GetMark()
        {
             object p = Avergage();
            if ((bool)(p = true))
            {
                if (RangeMark(Mark1) && RangeMark(Mark2) && RangeMark(Mark3))
                {
                    if (mark1 >= 2)
                    {
                        Console.WriteLine("Двоечники");
                    }
                    else

                    if (mark2 == 3)
                    {
                        Console.WriteLine("Троечники");
                    }
                    else
                        if (mark3 == 4)
                    {
                        Console.WriteLine("Хорошисты");
                    }
                    else { Console.WriteLine("Отличники"); }

                    
                }
                
            }
            return p;
        }

        public void GetStudent()
        {
          Console.WriteLine($"Его оценки-{mark1},{mark2},{mark3}\n{GetMark()}");
        }


    }
}
