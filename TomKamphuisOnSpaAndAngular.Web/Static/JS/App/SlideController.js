﻿angular.module('TomKamphuisApp', ['ngSanitize'])
    .controller('SlideController', function ($scope, $http) {
        $scope.title = "Loading...";

        $scope.selectSlide = function (slideTitle) {
            $scope.working = true;
            $scope.title = "Loading...";

            $http.get("/api/slide/" + slideTitle).success(function (data, status, headers, config) {
                $scope.slides = data.slides;
                $scope.title = data.currentSlide.pageTitle;
                $scope.templateUrl = data.currentSlide.slideContent;
            }).error(function (data, status, headers, config) {
                $scope.title = "Oops... something went wrong";
                $scope.working = false;
            });
        };
    });