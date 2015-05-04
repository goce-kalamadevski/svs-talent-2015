(function() {
    'use strict';

    angular.module('demoApp').controller('AboutController', aboutController);

    aboutController.$inject = ['$scope', 'common', '$modalInstance'];

    function aboutController($scope, common, $modalInstance) {
        $scope.closeModal = closeModal;

        function closeModal() {
            $modalInstance.dismiss();
        }
    }
})();