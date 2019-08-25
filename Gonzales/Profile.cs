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
        public int Speed { get; set; } = MouseParams.defaultSpeed;

        /// <summary>
        /// The mouse acceleration of this profile.
        /// </summary>
        /// <remarks>The default profile mouse acceleration is not the system default.</remarks>
        public bool Acceleration { get; set; } = false;


        // Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="Profile"/> class with the default properties.
        /// </summary>
        public Profile() { }

        /// <summary>
        /// Initialises a new instance of the <see cref="Profile"/> class with the specified properties.
        /// </summary>
        /// <param name="name">the name of this profile.</param>
        /// <param name="speed">the mouse speed of this profile.</param>
        /// <param name="acceleration">the mouse acceleration state of this profile.</param>
        public Profile(string name, int speed, bool acceleration)
        {
            Name = name;
            Speed = MouseParams.ValidateSpeed(speed);
            Acceleration = acceleration;
        }


        // Methods

        /// <summary>
        /// Applies this profile.
        /// </summary>
        public void Apply()
        {
            MouseParams.SetSpeed(Speed);
            MouseParams.SetAcceleration(Acceleration);
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
