'use strict';

app.controller('HomeCtrl', ['$scope', '$compile', function ($scope, $compile) {

    $scope.form.items = [];

    $scope.add = function (form) {
        var item = {
            text: form.text
        };
        form.text = '';
        $scope.form.items.push(item);
    }

}]);
