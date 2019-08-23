﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;  //
using System.Text;
using System.Threading.Tasks;

namespace martindes01.Gonzales
{
    class MouseParams
    {
        // See https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-systemparametersinfoa
        // See https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mouse_event#remarks


        // Constants

        private const bool defaultAcceleration = true;
        private const int defaultSpeed = 10;

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


        // Getters

        /// <summary>
        /// Determines whether system mouse acceleration is enabled.
        /// </summary>
        /// <para>System mouse acceleration has two levels when enabled. Only level one is used.</para>
        /// <returns><c>true</c> if mouse acceleration enabled</returns>
        public bool GetAcceleration()
        {
            // Allocate mouse parameters to integer array
            int[] parameters = new int[3];
            SystemParametersInfo(SPI_GETMOUSE, 0, GCHandle.Alloc(parameters, GCHandleType.Pinned).AddrOfPinnedObject(), 0);
            // Mouse acceleration stored last in the array
            // Mouse acceleration enabled if this value greater than 0
            return parameters[2] != 0;
        }

        /// <summary>
        /// Gets the default mouse acceleration state.
        /// </summary>
        /// <para>System mouse acceleration has two levels when enabled. Only level one is used.</para>
        /// <para>The default mouse acceleration state is <c>true</c>.</para>
        /// <returns>the default mouse acceleration state</returns>
        public bool GetDefaultAcceleration()
        {
            return defaultAcceleration;
        }

        /// <summary>
        /// Gets the default system mouse speed.
        /// </summary>
        /// <remarks>
        /// <para>Mouse speed is an integer between<c>1</c> and<c>20</c>, inclusive.</para>
        /// <para>The default system mouse speed is <c>10</c>.</para>
        /// </remarks>
        /// <returns>the default system mouse speed</returns>
        public int GetDefaultSpeed()
        {
            return defaultSpeed;
        }

        /// <summary>
        /// Gets the system mouse speed.
        /// </summary>
        /// <remarks>
        /// <para>Mouse speed is an integer between <c>1</c> and <c>20</c>, inclusive.</para>
        /// </remarks>
        /// <returns>the system mouse speed</returns>
        public unsafe int GetSpeed()
        {
            // Allocate mouse speed to new integer
            int speed;
            SystemParametersInfo(SPI_GETMOUSESPEED, 0, new IntPtr(&speed), 0);
            return speed;
        }


        // Setters

        /// <summary>
        /// Sets the system mouse acceleration.
        /// </summary>
        /// <remarks>
        /// <para>System mouse acceleration has two levels when enabled. Only level one is used.</para>
        /// <para>Both system mouse thresholds will be set to <c>0</c>.</para>
        /// </remarks>
        /// <param name="acceleration">whether mouse acceleration should be enabled</param>
        public void SetAcceleration(bool acceleration)
        {
            // Uninitialised default value of int is 0
            int[] parameters = new int[3];
            // Mouse acceleration stored last in array
            // Mouse acceleration level set to 1 if acceleration true
            // !! Mouse acceleration level 2 unused
            parameters[2] = acceleration ? 1 : 0;
            // Assign mouse parameters
            // !! Mouse thresholds 1 and 2 will be set to 0
            SystemParametersInfo(SPI_SETMOUSE, 0, GCHandle.Alloc(parameters, GCHandleType.Pinned).AddrOfPinnedObject(), SPIF_SENDCHANGE);
        }

        /// <summary>
        /// Sets the system mouse speed.
        /// </summary>
        /// <remarks>
        /// <para>Mouse speed is an integer between <c>1</c> and <c>20</c>, inclusive.</para>
        /// <para>If <paramref name="speed"/> is less than <c>1</c>, the mouse speed is set to <c>1</c>.</para>
        /// <para>If <paramref name="speed"/> is greater than <c>20</c>, the mouse speed is set to <c>20</c>.</para>
        /// </remarks>
        /// <param name="speed">the desired mouse speed</param>
        public void SetSpeed(int speed)
        {
            // Ensure value between 1 and 20 inclusive
            if (speed < 1)
            {
                speed = 1;
            }
            else if (speed > 20)
            {
                speed = 20;
            }
            // Assign mouse speed
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, new IntPtr(speed), 0);
        }
    }
}