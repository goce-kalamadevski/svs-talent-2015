(function () {
    'use strict';

    angular.module('demoApp').controller('FooterController', footerController);

    footerController.$inject = ['$scope'];

    function footerController($scope) {
        $scope.year = new Date().getFullYear().toString();
    }
})();