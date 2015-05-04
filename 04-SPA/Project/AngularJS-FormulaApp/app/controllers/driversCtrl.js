(function() {
    'use strict';

    angular.module('demoApp').controller('DriversController', driversController);

    driversController.$inject = ['$scope', 'common', 'formulaService'];

    function driversController($scope, common, formulaService) {       
        $scope.createImgFlagsUrl = common.createImgFlagsUrl;

        getDrivers();

        function getDrivers() {
            formulaService.getDrivers().then(function (result) {
                createLightObject(result);
            });
        }

        function createLightObject(data) {
            var standings = data.MRData.StandingsTable.StandingsLists[0];
            $scope.standings = {
                driverStandings: [],
                season: standings.season,
                round: standings.round
            };
            var driverStandings = standings.DriverStandings;
            $scope.drivers = [];
            angular.forEach(driverStandings, function (ds) {
                var driverStanding = {
                    driverId: ds.Driver.driverId,
                    position: ds.position,
                    nationality: ds.Driver.nationality,
                    fullName: ds.Driver.givenName + ' ' + ds.Driver.familyName,
                    wins: ds.wins,
                    points: ds.points
                };
                $scope.standings.driverStandings.push(driverStanding);
            });
        }
    }
})();