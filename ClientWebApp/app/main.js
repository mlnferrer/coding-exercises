(function () {
    'use strict';

    angular
        .module('app')
        .controller('Main', main);

    function main(MainService, NgTableParams) {
             
        var vm = this;
        MainService.getEmailTemplates().then(function () {
            vm.tableParams = new NgTableParams({},
                {
                    dataset: MainService.data,
                    counts: []
                },
            );
        });

    }

})();