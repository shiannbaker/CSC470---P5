using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Code
{
    public class FakeProjectRepository : IProjectRepository
    {
        const string NO_ERROR = "No Error.";
        const string MODIFIED_PROJECT_ID_ERROR = "Error Modifying Project ID.";
        const string DUPLICATE_PROJECT_NAME_ERROR = "Duplicate Project Detected.";
        const string NO_PROJECT_FOUND_ERROR = "Project Not Found.";
        const string EMPTY_PROJECT_NAME_ERROR = "Empty Project Name.";
        private static List<Project> projects = new List<Project>();

        private static Dictionary<string, Project> project;

        public FakeProjectRepository() //unique int vals as key
        {
            if (project == null)
            {
                project = new Dictionary<string, Project>();
                //add some
                project.Add("One", new Project
                {
                    Id = 1,
                    Name = "First Project",
                });
                project.Add("Two", new Project
                {
                    Id = 2,
                    Name = "Second Project",
                });
            }
        }

        public int GetNextId()
        {
            //get next project id

            return 0; //return id
        }

        /*public string Add(Project project, int Id)
        {
            
        }

        public string Remove(int projectId)
        {

        }

        public string Modify(int projectId, Project project)
        {

        }

        public List<Project> GetAll()
        {

        }

        public bool IsDuplicateName(string projectName)
        {

        }*/
    }
}
