namespace Task15._6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"  }, },
               new Classroom { Students = {"Anna",    "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat",   "Alex",   "Galina"  }, }
            };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            List<Classroom> Classrooms = classes.ToList(); // переводим массив classes в коллекцию Classrooms
            var res = Classrooms.SelectMany(x => x.Students); // обьединяем в коллекцию res
            string[] result = res.ToArray();// преобразуем в массив
            return result;

        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
    
}