
export function showPrompt(message)
{
    return prompt(message, 'Type anything here');
}

export function loadNavigation()
{
    onToggleSidebar(document.getElementById("ToggleSidebar"));
    onToggleSidebar(document.getElementById("ToggleSmallScreenMenu"));

    onCloseSidebar(document.getElementById("sidebar"));
    onCloseSidebar(document.getElementById("SmallScreenMenu"));

    onCloseMenu(document.getElementById("close_menu"));
    onCloseMenu(document.getElementById("button_home"));
}

export function onCloseMenu(element)
{
    if(element)
    {
        element.addEventListener('click', () =>
        {
            document.getElementById("sidebar").classList.remove('active');
        }, false);
    }
}

export function onCloseSidebar(element)
{
    if(element)
    {
        element.addEventListener('click', () =>
        {
            element.classList.toggle('active');
        }, false);
    }
}

export function onToggleSidebar(element)
{
    if(element)
    {
        element.addEventListener('click', () =>
        {
            if(element.id === "ToggleSidebar")
            {
                document.getElementById("sidebar").classList.toggle('active');
            }
            else if(element.id === "ToggleSmallScreenMenu")
            {
                document.getElementById("SmallScreenMenu").classList.toggle('active');
            }
        }, false);
    }
}
