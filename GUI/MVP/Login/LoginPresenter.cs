using System;
using BL.Services;

namespace GUI.MVP.Login
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly UserService _userService;

        public LoginPresenter(ILoginView view, UserService userService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));

            _view.SignInRequested += OnSignInRequested;
            _view.SignUpRequested += OnSignUpRequested;
        }

        private void OnSignInRequested(object? sender, EventArgs e)
        {
            try
            {
                var login = _view.Username;
                var password = _view.Password;

                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentException("Input error");
                }

                var user = _userService.LogIn(login, password);
                _view.NavigateToRole(user.Role, user.Id);
                _view.CloseView();
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void OnSignUpRequested(object? sender, EventArgs e)
        {
            _view.OpenSignUp();
        }
    }
}
