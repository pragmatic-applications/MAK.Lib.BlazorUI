﻿namespace Domain
{
    public class MenuState
    {
        public static bool ToggleSwitch = true;
        public static string SidebarCss => ToggleSwitch ? null : "active";
        public static string SmallScreenMenuCss => ToggleSwitch ? null : "active";

        public static void ToggleNavMenu() => ToggleSwitch = !ToggleSwitch;

        public static void CloseMenu() => ToggleSwitch = true;

        public static string BackUrl { get; set; }
        public static void SetBackUrl(string backUrl) => BackUrl = backUrl;

        public static string MenuMainCSS { get; set; } = "MenuMain";
    }
}
