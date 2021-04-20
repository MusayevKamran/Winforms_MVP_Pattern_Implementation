using System;
using Tutorial_Winforms_MVP_Pattern.Models;

namespace Tutorial_Winforms_MVP_Pattern.Interfaces
{
    public interface ILoginForm
    {
        User User { get; set; }

        event EventHandler Login;
    }
}