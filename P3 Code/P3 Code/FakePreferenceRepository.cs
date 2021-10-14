using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Code
{
    public class FakePreferenceRepository : IPreferenceRepository
    {
        public const string PREFERENCE_PROJECT_ID = "Project_Id";
        public const string PREFERENCE_PROJECT_NAME = "Project_Name";
        private const string NO_ERROR = "";
        private static Dictionary<string, Dictionary<string, string>> preferences = new Dictionary<string, Dictionary<string, string>>();
                            //Username; PreferenceName,preferencevalue; 

        public string GetPreference(string UserName, string PreferenceName)
        {
            Dictionary<string, string> NameValuePair = new Dictionary<string, string>();
            string value = "";
            if(preferences.TryGetValue(UserName, out NameValuePair))
            {
                NameValuePair.TryGetValue(PreferenceName, out value);
            }
            return value;
        }

        public string SetPreference(string UserName, string PreferenceName, string Value)
        {
            Dictionary<string, Dictionary<string, string>> preferences = new Dictionary<string, Dictionary<string, string>>();

            try
            {
                preferences.Add(UserName, new Dictionary<string, string>() ); //need to assign PreferenceName and Value
          
                return "";
            }
            catch (ArgumentException)
            {
                return "";
            }
            
        }


    }
}
