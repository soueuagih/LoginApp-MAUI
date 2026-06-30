//using System;
//using System.Collections.Generic;
//using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LoginAppMaui.ViewModels;

public partial class LoginPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string _email;

    [ObservableProperty]
    private string _password;
}
