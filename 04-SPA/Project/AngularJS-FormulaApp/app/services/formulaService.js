(function () {
    'use strict';

    var serviceId = 'formulaService';
    angular.module('demoApp').factory(serviceId, ['$http', formulaService]);

    function formulaService($http) {
        var service = {
            getDriverInfo: getDriverInfo,
            getDriverRaces: getDriverRaces,
            getDrivers: getDrivers,
            getConstructors: getConstructors,
            getRaces: getRaces
        };

        return service;

        function getDrivers() {
            var url = 'http://ergast.com/api/f1/2013/driverStandings.json';
            return $http.get(url).then(onSuccess, onError);
        }

        function getDriverInfo(driverId) {
            var url = 'http://ergast.com/api/f1/2013/drivers/' + driverId + '/driverStandings.json';
            return $http.get(url).then(onSuccess, onError);
        }

        function getDriverRaces(driverId) {
            var url = '';
            if (driverId) {
                url = 'http://ergast.com/api/f1/2013/drivers/' + driverId + '/results.json';
            }          
            return $http.get(url).then(onSuccess, onError);
        }
        
        function getConstructors() {
            var url = 'http://ergast.com/api/f1/2013/constructorStandings.json';
            return $http.get(url).then(onSuccess, onError);
        }

        function getRaces() {
            var url = 'http://ergast.com/api/f1/2013/results/1.json';
            return $http.get(url).then(onSuccess, onError);
        }

        function onSuccess(response) {
            return response.data;
        }

        function onError(reason) {
            console.log(reason);
        }
    }
})();