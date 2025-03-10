﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HotLyric.Input
{
    public enum MouseButton
    {
        /// <summary>
        ///    The left mouse button.
        /// </summary>
        Left,

        /// <summary>
        ///    The middle mouse button.
        /// </summary>
        Middle,

        /// <summary>
        ///    The right mouse button.
        /// </summary>
        Right,

        /// <summary>
        ///    The fourth mouse button.
        /// </summary>
        XButton1,

        /// <summary>
        ///    The fifth mouse button.
        /// </summary>
        XButton2
    }

    public enum MouseButtonState
    {
        /// <summary>
        ///    The button is released.
        /// </summary>
        Released,

        /// <summary>
        ///    The button is pressed.
        /// </summary>
        Pressed,

        // Update the IsValid helper in RawMouseState.cs if this enum changes.
    }
}
