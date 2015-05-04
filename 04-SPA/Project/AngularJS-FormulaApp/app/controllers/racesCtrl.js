(function() {
    'use strict';

    angular.module('demoApp').controller('RacesController', racesController);

    racesController.$inject = ['$scope', 'common', 'formulaService'];

    function racesController($scope, common, formulaService) {        
        $scope.raceTable = {};
        $scope.createImgFlagsUrl = common.createImgFlagsUrl;

        getRaces();

        function getRaces() {
            formulaService.getRaces().then(function (result) {
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
                    name: r.raceName,
                    date: r.date,
                    circuitName: r.Circuit.circuitName,
                    driverNationality: r.Results[0].Driver.nationality,
                    driverId: r.Results[0].Driver.driverId,
                    driverGivenName: r.Results[0].Driver.givenName,
                    driverFamilyName: r.Results[0].Driver.familyName
                };                
                lightObj.races.push(race);
            });
            $scope.raceTable = lightObj;
        }
    }
})();