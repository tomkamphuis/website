angular.module('TomKamphuisApp', [])
    .controller('SlideController', function ($scope, $http) {
        $scope.title = "Loading...";

        $scope.selectSlide = function (slideTitle) {
            $scope.working = true;
            $scope.title = "Loading...";

            $http.get("/api/slide/" + slideTitle).success(function (data, status, headers, config) {
                $scope.title = data.pageTitle;
                $scope.content = data.slideContent;
            }).error(function (data, status, headers, config) {
                $scope.title = "Oops... something went wrong";
                $scope.working = false;
            });
        };
    });