using System;
using System.Windows.Forms;

namespace GUI.MVP.Main
{
    public interface IMainFormView
    {
        event EventHandler? InfoRequested;
        event EventHandler? UsersViewRequested;
        event EventHandler? ProductsViewRequested;
        event EventHandler? OrdersViewRequested;
        event EventHandler? PromosViewRequested;
        event EventHandler? CartsViewRequested;
        event EventHandler? LogoutRequested;

        void DisplayChildForm(Form form);
        void ShowLogin();
    }
}
