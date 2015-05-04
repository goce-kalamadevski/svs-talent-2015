(function () {
    'use strict';

    angular.module('demoApp').controller('NavigationController', navigationController);

    navigationController.$inject = ['$rootScope', '$scope', '$modal'];

    function navigationController($rootScope, $scope, $modal) {

        $scope.showAboutModal = function() {
            $modal.open({
                templateUrl: 'app/templates/modal/about.html',
                controller: 'AboutController as vm',
                backdrop: false
            });
        };
    }
})();