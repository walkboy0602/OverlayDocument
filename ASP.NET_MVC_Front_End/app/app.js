'use strict';


var app = angular.module('app', [])

    .config(['$locationProvider', '$httpProvider',  function ($locationProvider, $httpProvider) {
        $locationProvider.html5Mode(false);
    }])

    .run(['$rootScope', '$window', function ($rootScope, $window) {

        $rootScope.form = {};
    }]);

