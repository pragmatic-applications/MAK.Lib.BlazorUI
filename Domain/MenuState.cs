namespace Domain
{
    public class MenuState
    {
        public static bool ToggleSwitch = true;
        public static string SidebarCss => ToggleSwitch ? null : "active";
        public static string SmallScreenMenuCss => ToggleSwitch ? null : "active";

        public static void ToggleNavMenu() => ToggleSwitch = !ToggleSwitch;

        public static void CloseMenu() => ToggleSwitch = true;

        public static string MenuMainCSS { get; set; } = "MenuMain";

        public static bool IsAdmin { get; set; }
        public static bool IsCreate { get; set; }

        public static string LinkValue { get; set; }
        public static void SetLinkValue(string linkValue) => LinkValue = linkValue;

        public static string Title { get; set; }
        public static void SetTitle(string title = null) => Title = title;
    }
}
