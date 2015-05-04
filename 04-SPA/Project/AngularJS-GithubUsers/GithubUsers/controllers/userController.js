(function () {

    var module = angular.module("githubViewer");

    module.controller("userController", userController);

    function userController($scope, $routeParams, githubService) {

        var onUser = function(data) {
            $scope.user = data;
            githubService.getRepos($scope.user).then(onRepos, onError);
        };

        var onRepos = function(data) {
            $scope.repos = data;
        };

        var onError = function(reason) {
            $scope.error = reason;
        };

        $scope.username = $routeParams.username;
        $scope.repoSortOrder = "-stargazers_count";
        githubService.getUser($scope.username).then(onUser, onError);        
    }
}());