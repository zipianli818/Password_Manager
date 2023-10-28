using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager.Controls;
internal interface IModal<TModalResult>
{
    /// <summary>
    /// Displays a Modal. This generic interace allows for modals to produce any result.
    /// </summary>
    /// <param name="title">Modal window title.</param>
    /// <param name="exclusive">If true then the modal blocks inputs to other forms.</param>
    /// <param name="onConfirm">Called when the modal is confirmed.</param>
    /// <param name="onCancel">Called when the modal is closed.</param>
    public static abstract void ShowModal(string title, bool exclusive, Action<TModalResult> onConfirm, Action? onCancel = null);
}
