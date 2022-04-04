
export function onToggleNavMenu(element)
{
    if(element)
    {
        element.addEventListener('click', () =>
        {
            if(element.id === "toggle_nav_menu")
            {
                document.getElementById("nav_menu").classList.toggle('active');
            }
        }, false);
    }
}
export function onCloseNavMenu(element)
{
    if(element)
    {
        element.addEventListener('click', () =>
        {
            if(element.id === "nav_menu")
            {
                document.getElementById("nav_menu").classList.toggle('active');
            }
        }, false);
    }
}

export function loadNavigation()
{
    onToggleNavMenu(document.getElementById("toggle_nav_menu"));
    onCloseNavMenu(document.getElementById("nav_menu"));
}
