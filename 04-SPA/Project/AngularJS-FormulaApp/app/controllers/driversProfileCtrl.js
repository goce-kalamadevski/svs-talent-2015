(function() {
    'use strict';

    angular.module('demoApp').controller('DriversProfileController', driversProfileController);

    driversProfileController.$inject = ['$scope', '$routeParams', 'common', 'formulaService'];

    function driversProfileController($scope, $routeParams, common, formulaService) {
        var id = $routeParams.id;        
        $scope.createImgDriversUrl = common.createImgDriversUrl;
        $scope.createImgFlagsUrl = common.createImgFlagsUrl;

        if (id) {
            getDriverInfo();
            getDriverRaces();
        }

        function getDriverInfo() {
            formulaService.getDriverInfo(id).then(function (result) {
                $scope.driverStandings = result.MRData.StandingsTable.StandingsLists[0].DriverStandings[0];
            });
        }

        function getDriverRaces() {
            formulaService.getDriverRaces(id).then(function (result) {                
                createLightObject(result);
            });
        }

        function createLightObject(data) {
            var raceTable = data.MRData.RaceTable;
            var lightObj = {
                season: raceTable.season,
                races: []
            };
            angular.forEach(raceTable.Races, function (r) {
                var race = {
                    circuitCountry: r.Circuit.Location.country,
                    round: r.round,
                    raceName: r.raceName,
                    team: r.Results[0].Constructor.name,
                    grid: r.Results[0].grid,
                    laps: r.Results[0].laps,
                    position: r.Results[0].position
                };
                lightObj.races.push(race);
            });
            $scope.raceTable = lightObj;
        }
    }
})();