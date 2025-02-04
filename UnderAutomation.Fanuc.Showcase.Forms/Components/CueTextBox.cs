using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

/// <summary>
///     ''' A Windows text box control with a cue banner.
///     ''' </summary>
public class CueTextBox : TextBox

{
    /// <summary>
    ///         ''' Contains platform invocation methods used by this class.
    ///         ''' </summary>
    private sealed class NativeMethods
    {
        /// <summary>
        ///             ''' The EM_SETCUEBANNER message - sets the textual cue.
        ///             ''' </summary>
        internal const uint EM_SETCUEBANNER = 0x1501;

        /// <summary>
        ///             ''' Sends the specified message to a window or windows.
        ///             ''' </summary>
        ///             ''' <param name="hWnd">
        ///             ''' A handle to the window whose window procedure will receive the message.
        ///             ''' </param>
        ///             ''' <param name="Msg">
        ///             ''' The message to be sent.
        ///             ''' </param>
        ///             ''' <param name="wParam">
        ///             ''' Additional message-specific information.
        ///             ''' </param>
        ///             ''' <param name="lParam">
        ///             ''' Additional message-specific information.
        ///             ''' </param>
        ///             ''' <returns>
        ///             ''' The result of the message processing.
        ///             ''' </returns>
        [DllImport("user32.dll", EntryPoint = "SendMessageW")]
        internal static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
    }

    /// <summary>
    ///         ''' The textual cue banner that is displayed by the control to prompt the user for
    ///         ''' information.
    ///         ''' </summary>
    private string m_cue;

    /// <summary>
    ///         ''' Gets or sets the textual cue banner that is displayed by the control to prompt the
    ///         ''' user for information.
    ///         ''' </summary>
    public string Cue
    {
        get
        {
            return this.m_cue;
        }

        set
        {
            this.m_cue = value;
            this.UpdateCue();
        }
    }

    /// <summary>
    ///         ''' Raises the HandleCreated event.
    ///         ''' </summary>
    ///         ''' <param name="e">An EventArgs that contains no event data.</param>
    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        this.UpdateCue();
    }

    /// <summary>
    ///         ''' Updates the textual cue.
    ///         ''' </summary>
    private void UpdateCue()
    {
        if (this.IsHandleCreated && this.m_cue != null)
            NativeMethods.SendMessage(this.Handle, NativeMethods.EM_SETCUEBANNER, (IntPtr)1, this.m_cue);
    }
}

