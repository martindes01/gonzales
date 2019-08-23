using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;  //
using System.Text;
using System.Threading.Tasks;

namespace martindes01.Gonzales
{
    /// <summary>
    /// Exposes static properties and methods for manipulating system mouse parameters.
    /// </summary>
    static class MouseParams
    {
        // See https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-systemparametersinfoa
        // See https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mouse_event#remarks


        // Fields

        /// <summary>
        /// The default mouse acceleration state, <c>true</c>.
        /// </summary>
        public static readonly bool defaultAcceleration = true;

        /// <summary>
        /// The default mouse speed, <c>10</c>.
        /// </summary>
        public static readonly int defaultSpeed = 10;

        // uiAction
        private const uint SPI_GETMOUSE = 0x0003;
        private const uint SPI_SETMOUSE = 0x0004;
        private const uint SPI_GETMOUSESPEED = 0x0070;
        private const uint SPI_SETMOUSESPEED = 0x0071;

        // fWinIni
        private const uint SPIF_SENDCHANGE = 0x0002;


        // Helper functions

        [DllImport("User32.dll")]
        private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

        /// <summary>
        /// Returns the closest value to <paramref name="speed"/> that falls between <c>1</c> and <c>20</c>, inclusive.
        /// </summary>
        /// <param name="speed">The speed to validate.</param>
        /// <returns>Returns the closest value to <paramref name="speed"/> that falls between <c>1</c> and <c>20</c>, inclusive.</returns>
        public static int ValidateSpeed(int speed)
        {
            if (speed < 1)
            {
                return 1;
            }
            else if (speed > 20)
            {
                return 20;
            }
            else
            {
                return speed;
            }
        }


        // Acceleration

        /// <summary>
        /// Determines whether mouse acceleration is enabled.
        /// </summary>
        /// <remarks>
        /// System mouse acceleration has two levels when enabled. Only level one is used.
        /// </remarks>
        /// <returns>Returns <c>true</c> if mouse acceleration enabled.</returns>
        public static bool GetAcceleration()
        {
            // Allocate mouse parameters to integer array
            int[] parameters = new int[3];
            SystemParametersInfo(SPI_GETMOUSE, 0, GCHandle.Alloc(parameters, GCHandleType.Pinned).AddrOfPinnedObject(), 0);
            // Mouse acceleration stored last in the array
            // Mouse acceleration enabled if this value greater than 0
            return parameters[2] != 0;
        }

        /// <summary>
        /// Sets the mouse acceleration state.
        /// </summary>
        /// <remarks>
        /// System mouse acceleration has two levels when enabled. Only level one is used.
        /// </remarks>
        /// <param name="acceleration">Whether mouse acceleration should be enabled.</param>
        public static void SetAcceleration(bool acceleration)
        {
            // Allocate mouse parameters to integer array
            int[] parameters = new int[3];
            SystemParametersInfo(SPI_GETMOUSE, 0, GCHandle.Alloc(parameters, GCHandleType.Pinned).AddrOfPinnedObject(), 0);
            // Mouse acceleration stored last in the array
            // Mouse acceleration level set to 1 if acceleration true (level 2 unused)
            parameters[2] = acceleration ? 1 : 0;
            // Assign altered mouse parameters
            SystemParametersInfo(SPI_SETMOUSE, 0, GCHandle.Alloc(parameters, GCHandleType.Pinned).AddrOfPinnedObject(), SPIF_SENDCHANGE);
        }


        // Speed

        /// <summary>
        /// Gets the current mouse speed.
        /// </summary>
        /// <remarks>
        /// Mouse speed is an integer between <c>1</c> and <c>20</c>, inclusive.
        /// </remarks>
        /// <returns>Returns the current mouse speed.</returns>
        public static unsafe int GetSpeed()
        {
            // Allocate mouse speed to new integer
            int speed;
            SystemParametersInfo(SPI_GETMOUSESPEED, 0, new IntPtr(&speed), 0);
            return speed;
        }
        
        /// <summary>
        /// Sets the system mouse speed to the closest value to <paramref name="speed"/> that falls between <c>1</c> and <c>20</c>, inclusive.
        /// </summary>
        /// <param name="speed">The desired mouse speed.</param>
        public static void SetSpeed(int speed)
        {
            // Ensure value between 1 and 20 inclusive
            speed = ValidateSpeed(speed);
            // Assign mouse speed
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, new IntPtr(speed), 0);
        }

    }
}
