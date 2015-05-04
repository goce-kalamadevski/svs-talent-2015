(function () {

    var app = angular.module("githubViewer");
    app.controller("mainController", mainController);

    function mainController($scope, $location) {

        $scope.search = function (username) {
            $location.path("/user/" + username);
        };
    };    
    
}());