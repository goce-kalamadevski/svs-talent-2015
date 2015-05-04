(function () {
    'use strict';

    var app = angular.module('demoApp', [
        // Angular modules includes.
        'ngRoute',
        // Custom modules includes.
        'common',
        'env-configuration',
        // 3rd party modules includes.
        'ui.bootstrap'
    ]);

    angular.module('env-configuration', [])
        .constant('common.urls', {
            imgFlagsResourceUrl: '/content/img/flags/',
            imgDriversResourceUrl: '/content/img/drivers/'
        });

    app.config(function ($routeProvider) {
        $routeProvider.
            when('/',
            {
                templateUrl: 'app/views/home.html'
            }).
            when('/drivers',
            {
                templateUrl: 'app/views/drivers.html',
                controller: 'DriversController'
            }).
            when('/drivers/:id',
            {
                templateUrl: 'app/views/driversProfile.html',
                controller: 'DriversProfileController'
            }).
            when('/races',
            {
                templateUrl: 'app/views/races.html',
                controller: 'RacesController'
            }).
            when('/teams',
            {
                templateUrl: 'app/views/teams.html',
                controller: 'TeamsController'
            }).
            otherwise({ redirectTo: '/' });
    });
}());