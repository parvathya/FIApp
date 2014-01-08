'use strict';
/* App Controllers */

productsApp.controller('loginController',
    function loginController($scope, productsService, sharedService) {
        //default values for dealerId, cashType
        $scope.cashType = true;
        sharedService.dealerId = 462;

        //get products from products service
        var products = productsService.getDealerProducts(sharedService.dealerId, $scope.cashType);
        products.then(function (data) {
            $scope.dealerProducts = data;
        });

    });