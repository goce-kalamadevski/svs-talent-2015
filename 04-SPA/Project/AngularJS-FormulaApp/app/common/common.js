(function () {
    'use strict';

    var commonModule = angular.module('common', []);

    commonModule.factory('common', ['common.urls', common]);

    function common(commonUrls) {

        var service = {
            createImgFlagsUrl: createImgFlagsUrl,
            createImgDriversUrl: createImgDriversUrl
        };

        return service;

        function createImgFlagsUrl(country) {
            return commonUrls.imgFlagsResourceUrl + country + '.png';
        }

        function createImgDriversUrl(driver) {
            return commonUrls.imgDriversResourceUrl + driver + '.png';
        }
    }
})();