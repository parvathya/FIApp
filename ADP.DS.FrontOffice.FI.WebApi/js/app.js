'use strict';

//Create spinner app module
var sharedServices = angular.module('spinner', []);
sharedServices.config(function ($httpProvider) {

    $httpProvider.responseInterceptors.push('myHttpInterceptor');
    var spinnerFunction = function (data) {
        new Spinner().spin(document.body);
        document.body.disabled = true;
        return data;
    };
    $httpProvider.defaults.transformRequest.push(spinnerFunction);
});

sharedServices.factory('myHttpInterceptor', function ($q) {
    return function (promise) {
        return promise.then(function (response) {
            var spinner = $(".spinner");
            document.body.disabled = false;
            spinner.remove();
            return response;

        }, function (response) {
            var spinner = $(".spinner");
            document.body.disabled = false;
            spinner.remove();
            return $q.reject(response);
        });
    };

});

//Declare the main app module and inject the spinner
var productsApp = angular.module('productsApp', ['spinner'])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.
        when('/login', {
            templateUrl: '/partials/login.html',
            controller: 'loginController'
        }).
        when('/products', {
            templateUrl: '/partials/products.html',
            controller: 'productsController'
        }).
        otherwise({
            redirectTo: '/login'
        });

    }]);