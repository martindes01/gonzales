using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace martindes01.Gonzales
{
    public partial class ProfileForm : Form
    {
        private readonly ProfileManager profileManager = new ProfileManager();

        public ProfileForm()
        {
            InitializeComponent();

            Profile profile1 = new Profile("1", 12, true);
            Profile profile2 = new Profile("2", 14, false);

            profileManager.Profiles.Add(profile1);
            profileManager.Profiles.Add(profile2);

            Console.WriteLine("Saving...");
            profileManager.SaveProfiles();

            profileManager.Profiles.Clear();

            Console.WriteLine("Loading...");
            profileManager.LoadProfiles();
        }
    }
}
