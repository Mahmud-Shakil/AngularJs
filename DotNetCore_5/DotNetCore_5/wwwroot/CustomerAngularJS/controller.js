/// <reference path="../angularjs/angular.js" />

customerAPP.controller('customerController', function ($scope, Upload, $timeout, customerService) {
    $scope.newCustomer = {};
  
    $scope.message = "";
    $scope.UploadFiles = function (files) {
        $scope.SelectedFiles = files;
        //$scope.newCustomer.ImageName = files[0].name;
        //$scope.clickedCustomer.ImageName = files[0].name;
    };
    CustomerList();
    function CustomerList() {
        customerService.CustomerList().then(function (result) {
            $scope.customers = result.data;
        })
    }
    $scope.Insert = function () {
        //if ($scope.SelectedFiles && $scope.SelectedFiles.length)
        //{
           
        //    UploadFile();
        //}
       
        customerService.insert($scope.newCustomer).then(function (returnId) {
            if ($scope.SelectedFiles && $scope.SelectedFiles.length) {
                UploadFile(returnId.data);
            }
        }).then(function (result) {
            $scope.message = "Customer Save Succfully";
            ClearAll();
            CustomerList();
        });
    }
    $scope.ClearMessage = function () {
        $scope.message = "";
    }
    function UploadFile(id) {
        Upload.upload({
            url: "api/FileUpload/UploadFiles?id="+id,
            data: {
                files: $scope.SelectedFiles
            }
        }).then(function (response) {
            $timeout(function () {
                $scope.Result = response.data;
                CustomerList();
            });
        }, function (response) {
            if (response.status > 0) {
                var errorMsg = response.status + ': ' + response.data;
                
            }
        });
    }
    function ClearAll() {
        $scope.newCustomer = null;
        $(".change_image").val('');
        $('.change_edit').attr('src', 'images/noI.jpg');
        //$scope.UploadFiles = null;
        //$scope.SelectedFiles = null;
        
    }
    $scope.SelectedCustomer = function (customer) {

        $scope.clickedCustomer = customer;
        $scope.clickedCustomer.DateOfBirth = new Date(customer.DateOfBirth)
    };

    $scope.UpdateCustomer = function () {
        customerService.updateCustomer($scope.clickedCustomer).then(function (returnId) {
            if ($scope.SelectedFiles && $scope.SelectedFiles.length) {
                UploadFile(returnId.data);
            }
        }).then(function (result) {
            $scope.message = "Data updated successfully";
            $scope.customers = result.data;
            CustomerList();
        }, function () {
            alert(result);
        });
        if ($scope.SelectedFiles && $scope.SelectedFiles.length) {
            UploadFile();
        }
    };
    $scope.DeleteCustomer = function (id) {
        customerService.deleteCustomer(id).then(function () {
            $scope.message = "Customer deleted successfully"
            CustomerList();
        }, function (result) {
            alert(result);
        })
    };
});

vechileApp.controller('vehicelController', function ($scope, Upload, $timeout, vehicelService) {
    $scope.newVehicel = {};
    $scope.message = "";
    $scope.UploadFiles = function (files) {
        $scope.SelectedFiles = files;
        $scope.newVehicel.ImageName = files[0].name;
        $scope.clickedVehicel.ImageName = files[0].name;


    };
    VehicelList();
    function VehicelList() {
        vehicelService.VehicelList().then(function (result) {
            $scope.vehicels = result.data;
        })
    }
    $scope.Insert = function () {
        if ($scope.SelectedFiles && $scope.SelectedFiles.length) {
            UploadFile();
        }
        vehicelService.insert($scope.newVehicel).then(function (result) {
            $scope.message = "Vehicel Save Succfully";
            ClearAll();
            VehicelList();
        });
    }
    $scope.ClearMessage = function () {
        $scope.message = "";
    }
    function UploadFile() {
        Upload.upload({
            url: "api/FileUpload/UploadVehicelFiles",
            data: {
                files: $scope.SelectedFiles
            }
        }).then(function (response) {
            $timeout(function () {
                $scope.Result = response.data;
            });
        }, function (response) {
            if (response.status > 0) {
                var errorMsg = response.status + ': ' + response.data;
                alert(errorMsg);
            }
        });
    }
    function ClearAll() {
        $scope.newVehicel = null;
        $(".change_image").val('');
        $('.change_edit').attr('src', 'images/noI.jpg');
    }
    $scope.SelectedVehicel = function (customer) {
        $scope.clickedVehicel = customer;
       /* $scope.DateOfBirth = new Date(customer.DateOfBirth)*/
    };

    $scope.UpdateVehicel = function () {
        vehicelService.updateVehicel($scope.clickedVehicel).then(function (result) {
            $scope.message = "Data updated successfully";
            $scope.vehicels = result.data;
            VehicelList();
        }, function () {
            alert(result);
        });
        if ($scope.SelectedFiles && $scope.SelectedFiles.length) {
            UploadFile();
        }
    };
    $scope.DeleteVehicel = function (id) {
        vehicelService.deleteVehicel(id).then(function () {
            $scope.message = "Customer deleted successfully"
            VehicelList();
        }, function (result) {
            alert(result);
        })
    };
});
