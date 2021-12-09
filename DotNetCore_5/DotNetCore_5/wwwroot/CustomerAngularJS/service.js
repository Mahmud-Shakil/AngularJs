customerAPP.service('customerService', function ($http) {
    this.CustomerList = function () {
        var response = $http.get('Customer/GetAll');
        return response;
    };
    this.insert = function (customer) {
        var response = $http({
            method: "POST",
            url: "Customer/Create",
            data: customer,
            contentType: false,
            processData: false
        });
        return response;
    };
    this.updateCustomer = function (customer) {
        var response = $http({
            method: 'post',
            url: 'Customer/Edit',
            data: customer,
            contentType: false,
            processData: false
        });
        return response;
    };
    this.deleteCustomer = function (id) {
        var response = $http({
            method: 'post',
            url: 'Customer/Delete?id=' + id,
            params: { CustomerId: JSON.stringify(id) }
        });
        return response;
    };
});

vechileApp.service('vehicelService', function ($http) {
    this.VehicelList = function () {
        var response = $http.get('Vehicel/GetAll');
        return response;
    };
    this.insert = function (customer) {
        var response = $http({
            method: "POST",
            url: "Vehicel/Create",
            data: customer,
            contentType: false,
            processData: false
        });
        return response;
    };
    this.updateVehicel = function (customer) {
        var response = $http({
            method: 'post',
            url: 'Vehicel/Edit',
            data: JSON.stringify(customer)
        });
        return response;
    };
    this.deleteVehicel = function (id) {
        var response = $http({
            method: 'post',
            url: 'Vehicel/Delete?id=' + id,
            params: { VehicleID: JSON.stringify(id) }
        });
        return response;
    };
});