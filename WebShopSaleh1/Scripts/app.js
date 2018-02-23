﻿var app = angular.module("CrudDemoApp", ["CrudDemoApp.controllers", "ngRoute"]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.
    when("/", { templateUrl: "/Partials/PlayerList.html", controller: "MainController" }).
    otherwise({ redirectTo: "/" });
}])