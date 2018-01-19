(function () {
    'use strict';

    angular
        .module('app')
        .factory('MainService', MainService);

    function MainService($http) {
        var service = {
            data: {},
            getEmailTemplates: getEmailTemplates
        };

        function getEmailTemplates() {

            var apiUrl = 'http://localhost:4126/';

            return $http({
                method: 'GET',
                url: apiUrl + 'api/EmailTemplates/',
            }).then(function (response) {
                service.data = response.data;
            }, function (error) {
                console.log(error);
            });

        }
        return service;
    }



})();