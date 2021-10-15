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
        private int ID = 1;

        private static Dictionary<string, Project> projects;

        public FakeProjectRepository() //unique int vals as key
        {
            if (projects == null)
            {
                projects = new Dictionary<string, Project>();
                //add some

                projects.Add("One", new Project
                {
                    Id = GetNextId(),
                    Name = "First Project",
                });
                
                projects.Add("Two", new Project
                {
                    Id = GetNextId(),
                    Name = "Second Project",
                });
            }
        }

        public int GetNextId()
        {
            //get next project id
            return ID++;
        }

        public string Add(Project project, string name) //here
        {
            CreateForm var = new CreateForm();
            string result = name.Trim();

            if (result == null || result == "")
            {
                return EMPTY_PROJECT_NAME_ERROR;
            }
            else if ( projects.ContainsKey(result) )//check for duplicate name
            {
                return DUPLICATE_PROJECT_NAME_ERROR;
            }
            else
            {
                projects.Add(result, new Project
                {
                    Id = GetNextId(),
                    Name = result,
                });
                return result;
            }
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
