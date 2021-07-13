using System.Collections.Generic;
using System.Linq;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task04
    {
        /*
         * Desenvolva um método que retorne todos os estudantes do Repositório que nasceram em 2020      
         * Dica: A classe Repository possui as informções dos Students
         */
        public static List<Student> GetStudentsByBirth() 
        {
            var result = new List<Student>();
            var repositorio = new Repository();
            foreach (Student estudante in repositorio.Students)
            {
                if (estudante.Birth.Year == 2020)
                {
                    result.Add(estudante);
                }
            }
            return result;
        }
    }
}
