namespace Views;

public partial class BSNavMain
{
    private string TopMenuCss => "close_menu-if_using_JS top_nav max_width_300 grid_xs_1 grid_md_2-";

    private string TopNavLinkCss => "top_nav_link text_center";
    private string SidebarNavLinkContainerCss => "sidebar_nav_link_container";
    private string SidebarNavLinkCss => "sidebar_nav_link";

    private string buttonHomeMainCss => MenuState.ToggleSwitch ? "button_home_main" : "button_home_main hide";
}
