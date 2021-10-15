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
        const string MODIFIED_PROJECT_ID_ERROR = "Can not modify the project id.";
        const string DUPLICATE_PROJECT_NAME_ERROR = "Project name already exists.";
        const string NO_PROJECT_FOUND_ERROR = "No project found.";
        const string EMPTY_PROJECT_NAME_ERROR = "Project name is empty or blank.";

        // Because these are static, they ch
        private static int ID = 0;
        private static List<Project> projects;

        public FakeProjectRepository() //unique int vals as key
        {
            if (projects == null)
            {
                projects = new List<Project>();
                //add some

                projects.Add(new Project
                {
                    Id = this.GetNextId(),
                    Name = "First Project",
                });
                
                projects.Add(new Project
                {
                    Id = this.GetNextId(),
                    Name = "Second Project",
                });
            }
        }

        public int GetNextId()
        {
            //get next project id
            return ++ID;
        }

        public string Add(Project project, string name) //here
        {
            FormCreate var = new FormCreate();

            if (name == null || name == "")
            {
                return EMPTY_PROJECT_NAME_ERROR;
            }
            else if ( projects.Contains(projects.Find(x => x.Name.Equals(name))) )  //check for duplicate name
            {
                return DUPLICATE_PROJECT_NAME_ERROR;
            }
            else
            {
                projects.Add(new Project
                {
                    Id = GetNextId(),
                    Name = name,
                });
                return NO_ERROR;
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
            foreach (Project x in projects)
            {
                _projects.Add(x);
            }
            return _projects;
        }

        public bool IsDuplicateName(string projectName)
        {
            return false;
        }
    }
}
