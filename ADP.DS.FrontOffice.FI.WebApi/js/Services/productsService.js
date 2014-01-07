'use strict';

productsApp.factory('productsService', function ($http, $q) {
    return {
        getDealerProducts: function (dealerId, cashType) {
            var deferred = $q.defer();
            
            //pass dealerId and cashType to webapi and retrieve dealer products
            $http.get('api/products/' + dealerId + '/' + cashType).
                success(function (data) {
                    deferred.resolve(data);
                }).
                error(function (status) {
                    deferred.reject(status);
                });

            return deferred.promise;
        }
    };
});


