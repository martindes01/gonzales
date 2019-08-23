using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO Doc comments

namespace martindes01.Gonzales
{
    /// <summary>
    /// Represents a user mouse profile.
    /// Provides properties and methods for creating and managing a mouse profile.
    /// </summary>
    class Profile
    {

        // Properties

        /// <summary>
        /// The name of this profile.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The mouse speed of this profile.
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// The mouse acceleration of this profile.
        /// </summary>
        public bool Acceleration { get; set; }


        // Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="Profile"/> class with the default properties.
        /// </summary>
        public Profile() {
            Name = "New profile";
            Speed = MouseParams.defaultSpeed;
            Acceleration = MouseParams.defaultAcceleration;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Profile"/> class with the specified properties.
        /// </summary>
        /// <param name="name">The name of this profile.</param>
        /// <param name="speed">The mouse speed of this profile.</param>
        /// <param name="acceleration">The mouse acceleration state of this profile.</param>
        public Profile(string name, int speed, bool acceleration)
        {
            Name = name;
            Speed = MouseParams.ValidateSpeed(speed);
            Acceleration = acceleration;
        }


        // Methods

        /// <summary>
        /// Returns the string representation of the mouse acceleration state.
        /// </summary>
        /// <returns>Returns the string representation of the mouse acceleration state.</returns>
        public String AccelerationToString()
        {
            return Acceleration ? "Enabled" : "Disabled";
        }

        /// <summary>
        /// Changes the properties of this profile to the specified properties.
        /// </summary>
        /// <param name="name">The new name of this profile.</param>
        /// <param name="speed">The new mouse speed of this profile.</param>
        /// <param name="acceleration">The new mouse acceleration state of this profile.</param>
        public void Edit(string name, int speed, bool acceleration)
        {
            Name = name;
            Speed = MouseParams.ValidateSpeed(speed);
            Acceleration = acceleration;
        }

        /// <summary>
        /// Sets the mouse speed of this profile to the nearest valid mouse speed.
        /// </summary>
        public void ValidateSpeed()
        {
            Speed = MouseParams.ValidateSpeed(Speed);
        }


        // Overrides

        /// <summary>
        /// Returns a string representation of this profile.
        /// </summary>
        /// <returns>Returns a string representation of this profile.</returns>
        public override string ToString()
        {
            return "Name: " + Name + ", Speed: " + Speed + ", Acceleration: " + Acceleration;
        }

    }
}
