using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO Doc comments

namespace martindes01.Gonzales
{
    public partial class ProfileForm : Form
    {

        // Constructors

        public ProfileForm()
        {
            InitializeComponent();

            Profile profile1 = new Profile("1", 12, true);
            Profile profile2 = new Profile("2", 14, false);

            ProfileManager.Profiles.Add(profile1);
            ProfileManager.Profiles.Add(profile2);

            ProfileManager.SaveProfiles();

            ProfileManager.Profiles.Clear();

            ProfileManager.LoadProfiles();
        }

    }
}
