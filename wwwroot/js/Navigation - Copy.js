
export function showPrompt(message)
{
    return prompt(message, 'Type anything here');
}

// === Navigation S ===
export function loadNavigation()
{
    onToggleNavMenu(document.getElementById("toggle_nav_menu"));
    //onCloseNavMenu(document.getElementById("nav_menu"));

    onCloseMenu(document.getElementById("nav_menu"));

    onCloseMenu(document.getElementById("button_home_main"));

    console.log("loadNavigation loaded...");
}

export function onCloseMenu(element)
{
    if(element)
    {
        element.addEventListener('click', () =>
        {
            document.getElementById("nav_menu").classList.remove('active');
        }, false);
    }
}

//
//export function onCloseNavMenu(element)
//{
//    if(element)
//    {
//        element.addEventListener('click', () =>
//        {
//            //element.classList.toggle('active'); // O
//            document.getElementById("nav_menu").classList.remove('active'); // N
//        }, false);
//    }
//}
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
// === Navigation E ===
