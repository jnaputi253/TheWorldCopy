(function() {
    /*$("#username").text("Juan Naputi");

    var main = $("#main");
    main.on("mouseenter", function() {
        main.style = "background-color: #888;";
    });
    main.on("mouseleave", function() {
        main.style.backgroundColor = "";
    });

    var menuItems = $("ul.menu li a");
*/

    var $sidebarAndWrapper = $("#sidebar, #wrapper");
    var $icon = $("#sideBarToggleButton i.fa")

    $("#sideBarToggleButton").on("click", function() {
        $sidebarAndWrapper.toggleClass("hide-sidebar");

        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        } else {
            $icon.removeClass("fa-angle-right");
            $icon.addClass("fa-angle-left");
        }
    });

})
();
