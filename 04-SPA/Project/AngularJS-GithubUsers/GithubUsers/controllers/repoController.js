(function() {

    var app = angular.module("githubViewer");
    app.controller("repoController", repoController);

    function repoController($scope, githubService, $routeParams) {
        
        var onSuccess = function(data) {
            $scope.repos = data;
        };

        var onError = function(reason) {
            $scope.error = reason;
        };

        var reponame = $routeParams.reponame;
        var username = $routeParams.username;
        githubService.getRepoDetails(username, reponame).then(onSuccess, onError);
    };    
}());