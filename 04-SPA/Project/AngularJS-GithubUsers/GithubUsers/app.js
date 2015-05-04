(function () {

    var app = angular.module("githubViewer", ["ngRoute"]);

    app.config(function ($routeProvider) {

        $routeProvider.
            when("/main", {
                templateUrl: "views/main.html",
                controller: "mainController"
            }).
            when("/user/:username", {
                templateUrl: "views/user.html",
                controller: "userController"
            }).
            when("/repo/:username/:reponame", {
                templateUrl: "views/repo.html",
                controller: "repoController"
            }).
            otherwise({ redirectTo: "/main" });
    });

}());