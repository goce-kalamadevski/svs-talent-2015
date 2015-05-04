(function() {
    'use strict';

    angular.module('demoApp').controller('TeamsController', teamsController);

    teamsController.$inject = ['$scope', 'common', 'formulaService'];

    function teamsController($scope, common, formulaService) {
        $scope.standings = {};
        $scope.createImgFlagsUrl = common.createImgFlagsUrl;

        getTeams();

        function getTeams() {
            formulaService.getConstructors().then(function(result) {
                createLightObject(result);
            });
        }

        function createLightObject(data) {
            var standings = data.MRData.StandingsTable.StandingsLists[0];
            var lightObj = {
                season: standings.season,
                round: standings.round,
                constructors: []
            };

            angular.forEach(standings.ConstructorStandings, function (cs) {
                var ctor = {
                    position: cs.position,
                    round: cs.round,
                    wins: cs.wins,
                    points: cs.points,
                    nationality: cs.Constructor.nationality,
                    name: cs.Constructor.name
                };
                
                lightObj.constructors.push(ctor);
            });
            $scope.standings = lightObj;
        }
    }
})();