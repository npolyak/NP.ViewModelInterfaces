using System;

namespace NP.ViewModelInterfaces.ThemingAndL10N
{
    public interface IThemeInfo
    {
        object Id { get; set; }

        Uri ResourceUrl { get; set; }

        Uri StyleUrl { get; set; }
    }
}   