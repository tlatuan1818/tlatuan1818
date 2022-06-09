var app = angular
    .module("NGUYEEN", ["ngRoute"])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "/Display/main.aspx",
                controller: "homeController"
            })
            .when("/fan-shop", {
                templateUrl: "/Display/fanshop.aspx",
                controller: "fanshopController"
            })
        $locationProvider.html5Mode(true);
    })
    .controller("homeController", function () {

    })
    .controller("fanshopController", function () {

    })