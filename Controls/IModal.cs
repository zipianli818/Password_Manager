using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager.Controls;
internal interface IModal<TModalResult>
{
    public static abstract void ShowModal(string title, Action<TModalResult> onConfirm);
    public static abstract void ShowModal(string title, Action<TModalResult> onConfirm, Action? onCancel);
}
