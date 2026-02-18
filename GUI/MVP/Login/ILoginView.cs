using System;
using BL.Models;

namespace GUI.MVP.Login
{
    public interface ILoginView
    {
        string Username { get; }
        string Password { get; }

        event EventHandler SignInRequested;
        event EventHandler SignUpRequested;

        void ShowError(string message);
        void OpenSignUp();
        void NavigateToRole(Role role, int userId);
        void CloseView();
    }
}
