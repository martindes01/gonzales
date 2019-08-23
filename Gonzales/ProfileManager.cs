using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;  //
using System.IO;  //

// TODO Handle exceptions
using System.Diagnostics;  //

namespace martindes01.Gonzales
{
    class ProfileManager
    {

        // Fields

        private readonly string dirPath;
        private readonly string companyName = "martindes01";
        private readonly string fileName = "profiles.json";
        private readonly string filePath;
        private readonly string productName = "Gonzales";

        private JavaScriptSerializer jsSerializer = new JavaScriptSerializer();


        // Properties

        public List<Profile> Profiles { get; } = new List<Profile>();


        // Constructors

        public ProfileManager()
        {
            // Compute directory and file paths
            dirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), companyName, productName);
            filePath = Path.Combine(dirPath, fileName);

            Console.WriteLine("Dir: {0}", dirPath);
            Console.WriteLine("File: {0}", filePath);

            // Create directory
            Directory.CreateDirectory(dirPath);
        }


        // Methods

        public void LoadProfiles()
        {
            // Check profiles file exists
            if (File.Exists(filePath))
            {
                // Load JSON from file
                string jsonData = File.ReadAllText(filePath);

                Console.WriteLine("Loaded: {0}", jsonData);

                // Deserialise JSON to type List<Profile> and add to Profiles
                var sw1 = new Stopwatch();
                sw1.Start();
                Profiles.AddRange(jsSerializer.Deserialize<List<Profile>>(jsonData));
                sw1.Stop();
                Console.WriteLine(sw1.ElapsedMilliseconds);

                for (int i = 0; i < Profiles.Count; i++)
                {
                    Console.WriteLine("Profile {0}: {1}, {2}, {3}", i, Profiles[i].Name, Profiles[i].Speed, Profiles[i].Acceleration);
                }
            }
        }

        public void SaveProfiles()
        {
            // Serialise Profiles to JSON
            string jsonData = jsSerializer.Serialize(Profiles);

            Console.WriteLine("Serialised: {0}", jsonData);

            // Save JSON to file
            File.WriteAllText(filePath, jsonData);
        }

    }
}
