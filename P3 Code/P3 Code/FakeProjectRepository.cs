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

        private static Dictionary<string, Project> projects;

        public FakeProjectRepository() //unique int vals as key
        {
            if (projects == null)
            {
                projects = new Dictionary<string, Project>();
                //add some
                projects.Add("One", new Project
                {
                    Id = 1,
                    Name = "First Project",
                });
                projects.Add("Two", new Project
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

        public string Add(Project project, int Id)
        {
            return "";
        }

        public string Remove(int projectId)
        {
            return "";
        }

        public string Modify(int projectId, Project project)
        {
            return "";
        }

        public List<Project> GetAll()
        {
            //return all
            List<Project> _projects = new List<Project>();
            foreach (KeyValuePair<string, Project> project in projects)
            {
                _projects.Add(project.Value);
            }
            return _projects;
        }

        public bool IsDuplicateName(string projectName)
        {
            return false;
        }
    }
}
