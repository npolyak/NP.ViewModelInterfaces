using System;

namespace NP.ViewModelInterfaces.ThemingAndL10N
{
    public interface IThemeLoader
    {
        event Action<IThemeLoader> SelectedThemeChangedEvent;

        object? SelectedThemeId { get; set; }

        public IThemeInfo? TheSelectedTheme { get; }

        void AddDictionary(object themeId, Uri resourcesUri, Uri styleUri = null);
    }
}
