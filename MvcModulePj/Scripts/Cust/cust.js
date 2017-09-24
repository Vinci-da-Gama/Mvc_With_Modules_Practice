$(document).ready(function () {
    var sidebarSelector = '.ui.left.sidebar';
    SidebarAction(sidebarSelector);

    //var dropdownSelector = '.ui .dropdown';
    //DropDownMenu(dropdownSelector);
});

function SidebarAction(sb) {
    $(sb).sidebar({
        transition: 'overlay'
    });
    // left is opened by button
    $(sb).sidebar('attach events', '#menu');
};

function DropDownMenu(dd) {
    $(dd).dropdown({
        on: 'hover'
    });
}