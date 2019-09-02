using System;
using System.Collections.Generic;
using System.ComponentModel;  //
using System.IO;  //
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;  //
using System.Windows.Forms;  //

// TODO Handle exceptions

namespace martindes01.Gonzales
{
    /// <summary>
    /// Exposes static properties and methods for managing and saving mouse profiles.
    /// </summary>
    internal static class ProfileManager
    {

        // Fields
        
        private static readonly string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.CompanyName, Application.ProductName, "profiles.json");

        private static readonly JavaScriptSerializer jsSerializer = new JavaScriptSerializer();


        // Properties

        /// <summary>
        /// The list of mouse profiles.
        /// </summary>
        public static List<Profile> Profiles { get; } = new List<Profile>();


        // Constructors

        static ProfileManager() { }


        // Methods

        /// <summary>
        /// Loads the profiles from the saved json file into the <see cref="Profiles"/> property, if the file exists.
        /// </summary>
        public static void LoadProfiles()
        {
            // Check profiles file exists
            if (File.Exists(filePath))
            {
                // Load JSON from file
                string jsonData = File.ReadAllText(filePath);

                // Clear old profiles
                Profiles.Clear();
                
                // Deserialise JSON to type List<Profile> and add to Profiles
                Profiles.AddRange(jsSerializer.Deserialize<List<Profile>>(jsonData));

                // Ensure valid mouse speeds
                foreach (Profile profile in Profiles)
                {
                    profile.ValidateSpeed();
                }

                // DEBUG
                Console.WriteLine(ProfilesToString());
            }
        }

        /// <summary>
        /// Returns a string reresentation of profiles stored in the <see cref="Profiles"/> property.
        /// </summary>
        /// <returns>Returns a string reresentation of stored profiles.</returns>
        public static string ProfilesToString()
        {
            StringBuilder stringBuilder = new StringBuilder("Profiles (" + Profiles.Count + "):");
            foreach (Profile profile in Profiles)
            {
                stringBuilder.Append("\n\t" + profile.ToString());
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Saves the <see cref="Profiles"/> property to a json file.
        /// </summary>
        public static void SaveProfiles()
        {
            // Serialise Profiles to JSON
            string jsonData = jsSerializer.Serialize(Profiles);

            // DEBUG
            Console.WriteLine(jsonData);

            // Save JSON to file
            File.WriteAllText(filePath, jsonData);
        }

    }
}
