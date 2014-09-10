var tkServices = angular.module('tkServices', ['ngSanitize', 'ngRoute']);

function SlideController($scope, $http, $location) {
    $scope.selectSlide = function (slideTitle) {
        $scope.working = true;

        $http.get("/api/slide/" + slideTitle).success(function (data, status, headers, config) {
            $scope.slides = data.slides;
            $scope.title = data.currentSlide.pageTitle;
            $scope.templateUrl = data.currentSlide.slideContent;
        }).error(function (data, status, headers, config) {
            $scope.working = false;
        });
    };

    var slideToSelect = $location.path().replace('/', '');
    if (slideToSelect === undefined) {
        slideToSelect = 'Profile';
    }

    $scope.selectSlide(slideToSelect);
};

tkServices.config(function ($routeProvider, $locationProvider) {
    $routeProvider.
        when('/Profile', {
            controller: SlideController,
            templateUrl: '/Static/HTML/App/_ProfilePartial.html'
        })
        .when('/Resume', {
            controller: SlideController,
            templateUrl: '/Static/HTML/App/_ResumePartial.html'
        })
        .when('/Portfolio', {
            controller: SlideController,
            templateUrl: '/Static/HTML/App/_PortfolioPartial.html'
        })
        .when('/Contact', {
            controller: SlideController,
            templateUrl: '/Static/HTML/App/_ContactPartial.html'
        })
        .otherwise({
            redirectTo: '/Profile'
        });

    $locationProvider.html5Mode(true);
});