webpackJsonp(["main"],{

/***/ "../../../../../src/$$_gendir lazy recursive":
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncatched exception popping up in devtools
	return Promise.resolve().then(function() {
		throw new Error("Cannot find module '" + req + "'.");
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "../../../../../src/$$_gendir lazy recursive";

/***/ }),

/***/ "../../../../../src/app/admin-product-gestion/admin-product-gestion.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/admin-product-gestion/admin-product-gestion.component.html":
/***/ (function(module, exports) {

module.exports = "\r\n"

/***/ }),

/***/ "../../../../../src/app/admin-product-gestion/admin-product-gestion.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AdminProductGestionComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var AdminProductGestionComponent = (function () {
    function AdminProductGestionComponent() {
    }
    AdminProductGestionComponent.prototype.ngOnInit = function () {
    };
    return AdminProductGestionComponent;
}());
AdminProductGestionComponent = __decorate([
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["n" /* Component */])({
        selector: 'app-admin-product-gestion',
        template: __webpack_require__("../../../../../src/app/admin-product-gestion/admin-product-gestion.component.html"),
        styles: [__webpack_require__("../../../../../src/app/admin-product-gestion/admin-product-gestion.component.css")]
    }),
    __metadata("design:paramtypes", [])
], AdminProductGestionComponent);

//# sourceMappingURL=admin-product-gestion.component.js.map

/***/ }),

/***/ "../../../../../src/app/app.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/app.component.html":
/***/ (function(module, exports) {

module.exports = "<!--The content below is only a placeholder and can be replaced.-->\r\n\r\n<app-list-product (orderProductChange)=\"tmpOrderProduct=$event\" (productsChange)=\"tmpProduct=$event\"></app-list-product>\r\n\r\n<app-current-order\r\n  [currentOrderInjected]=\"tmpOrderProduct\"\r\n  (orderValidated)= \"tmpCurrentOrder = $event\">\r\n</app-current-order>\r\n\r\n<app-list-order [orderInjected]=\"tmpCurrentOrder\"></app-list-order>\r\n\r\n<app-admin-product-gestion></app-admin-product-gestion>\r\n"

/***/ }),

/***/ "../../../../../src/app/app.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};

var AppComponent = (function () {
    function AppComponent() {
    }
    return AppComponent;
}());
AppComponent = __decorate([
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["n" /* Component */])({
        selector: 'app-root',
        template: __webpack_require__("../../../../../src/app/app.component.html"),
        styles: [__webpack_require__("../../../../../src/app/app.component.css")]
    })
], AppComponent);

//# sourceMappingURL=app.component.js.map

/***/ }),

/***/ "../../../../../src/app/app.module.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppModule; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_platform_browser__ = __webpack_require__("../../../platform-browser/@angular/platform-browser.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__angular_forms__ = __webpack_require__("../../../forms/@angular/forms.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__app_component__ = __webpack_require__("../../../../../src/app/app.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__list_product_list_product_component__ = __webpack_require__("../../../../../src/app/list-product/list-product.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__current_order_current_order_component__ = __webpack_require__("../../../../../src/app/current-order/current-order.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6__list_order_list_order_component__ = __webpack_require__("../../../../../src/app/list-order/list-order.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_7__admin_product_gestion_admin_product_gestion_component__ = __webpack_require__("../../../../../src/app/admin-product-gestion/admin-product-gestion.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_8__produit_manager_service__ = __webpack_require__("../../../../../src/app/produit-manager.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_9__angular_common_http__ = __webpack_require__("../../../common/@angular/common/http.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};










var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    Object(__WEBPACK_IMPORTED_MODULE_1__angular_core__["L" /* NgModule */])({
        declarations: [
            __WEBPACK_IMPORTED_MODULE_3__app_component__["a" /* AppComponent */],
            __WEBPACK_IMPORTED_MODULE_4__list_product_list_product_component__["a" /* ListProductComponent */],
            __WEBPACK_IMPORTED_MODULE_5__current_order_current_order_component__["a" /* CurrentOrderComponent */],
            __WEBPACK_IMPORTED_MODULE_6__list_order_list_order_component__["a" /* ListOrderComponent */],
            __WEBPACK_IMPORTED_MODULE_7__admin_product_gestion_admin_product_gestion_component__["a" /* AdminProductGestionComponent */]
        ],
        imports: [
            __WEBPACK_IMPORTED_MODULE_0__angular_platform_browser__["a" /* BrowserModule */],
            __WEBPACK_IMPORTED_MODULE_2__angular_forms__["a" /* FormsModule */],
            __WEBPACK_IMPORTED_MODULE_9__angular_common_http__["b" /* HttpClientModule */],
        ],
        providers: [__WEBPACK_IMPORTED_MODULE_8__produit_manager_service__["a" /* ProduitManagerService */]],
        bootstrap: [__WEBPACK_IMPORTED_MODULE_3__app_component__["a" /* AppComponent */]]
    })
], AppModule);

//# sourceMappingURL=app.module.js.map

/***/ }),

/***/ "../../../../../src/app/current-order/current-order.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/current-order/current-order.component.html":
/***/ (function(module, exports) {

module.exports = "<h2>Commande actuelle</h2>\r\n<ul>\r\n  <li *ngFor=\"let orderProduct of currentOrder.orderProducts;\">\r\n    {{orderProduct.product.name}} {{orderProduct.quantity}}\r\n  </li>\r\n</ul>\r\n<button (click)=\"emitAndResetOrder()\">Valider la commande</button>\r\n\r\n\r\n"

/***/ }),

/***/ "../../../../../src/app/current-order/current-order.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return CurrentOrderComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__order_product__ = __webpack_require__("../../../../../src/app/order-product.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__order__ = __webpack_require__("../../../../../src/app/order.ts");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var CurrentOrderComponent = (function () {
    function CurrentOrderComponent() {
        this.orderValidated = new __WEBPACK_IMPORTED_MODULE_0__angular_core__["w" /* EventEmitter */]();
        this.currentOrder = new __WEBPACK_IMPORTED_MODULE_2__order__["a" /* Order */]();
    }
    CurrentOrderComponent.prototype.ngOnInit = function () {
    };
    CurrentOrderComponent.prototype.ngOnChanges = function (changes) {
        var tmpOrderProduct = changes["currentOrderInjected"].currentValue;
        if (tmpOrderProduct) {
            this.currentOrder.addOrChangeQuantityProduct(tmpOrderProduct.product, tmpOrderProduct.quantity);
        }
    };
    CurrentOrderComponent.prototype.emitAndResetOrder = function () {
        this.emitOrderValidated();
        this.currentOrder = new __WEBPACK_IMPORTED_MODULE_2__order__["a" /* Order */]();
    };
    CurrentOrderComponent.prototype.emitOrderValidated = function () {
        this.orderValidated.next(this.currentOrder);
    };
    return CurrentOrderComponent;
}());
__decorate([
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["E" /* Input */])(),
    __metadata("design:type", typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__order_product__["a" /* OrderProduct */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__order_product__["a" /* OrderProduct */]) === "function" && _a || Object)
], CurrentOrderComponent.prototype, "currentOrderInjected", void 0);
__decorate([
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["R" /* Output */])(),
    __metadata("design:type", typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_0__angular_core__["w" /* EventEmitter */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_0__angular_core__["w" /* EventEmitter */]) === "function" && _b || Object)
], CurrentOrderComponent.prototype, "orderValidated", void 0);
CurrentOrderComponent = __decorate([
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["n" /* Component */])({
        selector: 'app-current-order',
        template: __webpack_require__("../../../../../src/app/current-order/current-order.component.html"),
        styles: [__webpack_require__("../../../../../src/app/current-order/current-order.component.css")]
    }),
    __metadata("design:paramtypes", [])
], CurrentOrderComponent);

var _a, _b;
//# sourceMappingURL=current-order.component.js.map

/***/ }),

/***/ "../../../../../src/app/list-order/list-order.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/list-order/list-order.component.html":
/***/ (function(module, exports) {

module.exports = "<h2>Total de toutes mes commandes</h2>\r\n{{totalOfAllOrders()}} €\r\n"

/***/ }),

/***/ "../../../../../src/app/list-order/list-order.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ListOrderComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__order__ = __webpack_require__("../../../../../src/app/order.ts");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var ListOrderComponent = (function () {
    function ListOrderComponent() {
        this.orders = [];
    }
    ListOrderComponent.prototype.ngOnInit = function () {
    };
    ListOrderComponent.prototype.ngOnChanges = function (changes) {
        if (this.orderInjected) {
            this.orders.push(this.orderInjected);
        }
    };
    ListOrderComponent.prototype.totalOfAllOrders = function () {
        return this.orders.reduce(function (tot, currentValue) {
            return tot + currentValue.totalAllOrder();
        }, 0);
    };
    return ListOrderComponent;
}());
__decorate([
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["E" /* Input */])(),
    __metadata("design:type", typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__order__["a" /* Order */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__order__["a" /* Order */]) === "function" && _a || Object)
], ListOrderComponent.prototype, "orderInjected", void 0);
ListOrderComponent = __decorate([
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["n" /* Component */])({
        selector: 'app-list-order',
        template: __webpack_require__("../../../../../src/app/list-order/list-order.component.html"),
        styles: [__webpack_require__("../../../../../src/app/list-order/list-order.component.css")]
    }),
    __metadata("design:paramtypes", [])
], ListOrderComponent);

var _a;
//# sourceMappingURL=list-order.component.js.map

/***/ }),

/***/ "../../../../../src/app/list-product/list-product.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/list-product/list-product.component.html":
/***/ (function(module, exports) {

module.exports = "<input type=\"button\" name=\"ajouter\" value=\"Ajouter\">\r\n<input type=\"button\" name=\"supprimer\" value=\"Supprimer\">\r\n<input type=\"button\" name=\"modifier\" value=\"Modifier\">\r\n\r\n<!--<div *ngIf=\".isSelected()\">-->\r\n<form #formProduct=\"ngForm\" (submit)=\"createProduct()\">\r\n  Name :\r\n  <input type=\"text\" name=\"name\" [(ngModel)]=\"tmpProduct.name\" required>\r\n  Prix :\r\n  <input type=\"number\" name=\"price\" [(ngModel)]=\"tmpProduct.price\" required>\r\n  Stock :\r\n  <input type=\"number\" name=\"stock\" [(ngModel)]=\"tmpProduct.stock\" required>\r\n  Categorie :\r\n  <input type=\"text\" name=\"categorie\" [(ngModel)]=\"tmpProduct.categorie\" required>\r\n  Valeur de la promo :\r\n  <input type=\"number\" name=\"promo\" [(ngModel)]=\"tmpProduct.promo\" required>\r\n  Url de l'image :\r\n  <input type=\"text\" name=\"url\" [(ngModel)]=\"tmpProduct.urlImage\">\r\n\r\n  <input type=\"submit\" [disabled]=\"!formProduct.form.valid\">\r\n\r\n  {{tmpProduct|json}}\r\n</form>\r\nHey hey hey\r\n<p *ngFor=\"let prod of listProduct;\">\r\n  {{prod.name | uppercase}}\r\n  <img [src]=\"prod.urlImage\" height=\"100\" width=\"100\"/>\r\n\r\n  <input type=\"button\" value=\"+\" (click)=\"incrementQuantityOfProduct(prod)\">\r\n  <input type=\"button\" value=\"-\" (click)=\"decrementQuantityOfProduct(prod)\">\r\n</p>\r\n<!--</div>-->\r\n<h1>Supprimer</h1>\r\n<p *ngFor=\"let prod of listProduct;\">\r\n  {{prod.name | uppercase}}\r\n  <img [src]=\"prod.urlImage\" height=\"100\" width=\"100\"/>\r\n  <input type=\"button\" value=\"supprimer\" (click)=\"deleteProduct(prod)\">\r\n</p>\r\n<h1>Update</h1>\r\n<p *ngFor=\"let prod of listProduct;\">\r\n  {{prod.name | uppercase}}\r\n  <img [src]=\"prod.urlImage\" height=\"100\" width=\"100\"/>\r\n  <input type=\"text\" name=\"name\" [value]=\"prod.name\">\r\n  <input type=\"number\" name=\"price\" [value]=\"prod.price\">\r\n  <input type=\"number\" name=\"stock\" [value]=\"prod.stock\">\r\n  <input type=\"text\" name=\"url\" [value]=\"prod.urlImage\">\r\n\r\n <!-- <input type=\"submit\" (click)=\"updateProduct(prod,name,price,stock,url)\">-->\r\n\r\n</p>\r\n\r\n\r\n\r\n\r\n"

/***/ }),

/***/ "../../../../../src/app/list-product/list-product.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ListProductComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__product__ = __webpack_require__("../../../../../src/app/product.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__order_product__ = __webpack_require__("../../../../../src/app/order-product.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3_q__ = __webpack_require__("../../../../q/q.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3_q___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_3_q__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__produit_manager_service__ = __webpack_require__("../../../../../src/app/produit-manager.service.ts");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};





var ListProductComponent = (function () {
    function ListProductComponent(productService) {
        this.productService = productService;
        this.tmpProduct = new __WEBPACK_IMPORTED_MODULE_1__product__["a" /* Product */]();
        this.listProduct = [];
        this.orderProductChange = new __WEBPACK_IMPORTED_MODULE_0__angular_core__["w" /* EventEmitter */]();
        this.productsChange = new __WEBPACK_IMPORTED_MODULE_0__angular_core__["w" /* EventEmitter */]();
    }
    ListProductComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.productService.getAllProduit().subscribe(function (listProduct) {
            _this.listProduct = __WEBPACK_IMPORTED_MODULE_1__product__["a" /* Product */].fromJSONs(listProduct);
            _this.emitProducts();
        });
    };
    ListProductComponent.prototype.returnProductList = function () {
        return this.listProduct;
    };
    ListProductComponent.prototype.createProduct = function () {
        this.listProduct.push(this.tmpProduct);
        this.tmpProduct = new __WEBPACK_IMPORTED_MODULE_1__product__["a" /* Product */];
    };
    ListProductComponent.prototype.emitProducts = function () {
        this.productsChange.next(this.listProduct);
    };
    ListProductComponent.prototype.emitOrderProduct = function (product, addQuantity) {
        this.orderProductChange.next(new __WEBPACK_IMPORTED_MODULE_2__order_product__["a" /* OrderProduct */](product, addQuantity ? 1 : -1));
    };
    ListProductComponent.prototype.incrementQuantityOfProduct = function (product) {
        this.emitOrderProduct(product, true);
    };
    ListProductComponent.prototype.decrementQuantityOfProduct = function (product) {
        this.emitOrderProduct(product, false);
    };
    ListProductComponent.prototype.deleteProduct = function (product) {
        var index = this.listProduct.findIndex(function (product) { return product.name === name; });
        this.listProduct.splice(index, 1);
        Object(__WEBPACK_IMPORTED_MODULE_3_q__["resolve"])(true);
    };
    ListProductComponent.prototype.updateProduct = function (product, value1, value2, value3, value4) {
    };
    return ListProductComponent;
}());
__decorate([
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["R" /* Output */])(),
    __metadata("design:type", typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_0__angular_core__["w" /* EventEmitter */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_0__angular_core__["w" /* EventEmitter */]) === "function" && _a || Object)
], ListProductComponent.prototype, "orderProductChange", void 0);
__decorate([
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["R" /* Output */])(),
    __metadata("design:type", typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_0__angular_core__["w" /* EventEmitter */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_0__angular_core__["w" /* EventEmitter */]) === "function" && _b || Object)
], ListProductComponent.prototype, "productsChange", void 0);
ListProductComponent = __decorate([
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["n" /* Component */])({
        selector: 'app-list-product',
        template: __webpack_require__("../../../../../src/app/list-product/list-product.component.html"),
        styles: [__webpack_require__("../../../../../src/app/list-product/list-product.component.css")]
    }),
    __metadata("design:paramtypes", [typeof (_c = typeof __WEBPACK_IMPORTED_MODULE_4__produit_manager_service__["a" /* ProduitManagerService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_4__produit_manager_service__["a" /* ProduitManagerService */]) === "function" && _c || Object])
], ListProductComponent);

var _a, _b, _c;
//# sourceMappingURL=list-product.component.js.map

/***/ }),

/***/ "../../../../../src/app/order-product.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return OrderProduct; });
var OrderProduct = (function () {
    function OrderProduct(product, quantity) {
        if (quantity === void 0) { quantity = 0; }
        this._product = product;
        this._quantity = quantity;
    }
    Object.defineProperty(OrderProduct.prototype, "product", {
        get: function () {
            return this._product;
        },
        set: function (value) {
            this._product = value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(OrderProduct.prototype, "quantity", {
        get: function () {
            return this._quantity;
        },
        set: function (value) {
            this._quantity = (value < 0) ? 0 : value;
        },
        enumerable: true,
        configurable: true
    });
    OrderProduct.prototype.total = function () {
        return this._product.price * this.quantity;
    };
    OrderProduct.prototype.incrQuantity = function () {
        this.relativeModificationQuantity(1);
    };
    OrderProduct.prototype.decrQuantity = function () {
        this.relativeModificationQuantity(-1);
    };
    OrderProduct.prototype.relativeModificationQuantity = function (quantityToMod) {
        this.quantity += quantityToMod;
        this.product.editRelativeVariationStock(quantityToMod);
    };
    return OrderProduct;
}());

//# sourceMappingURL=order-product.js.map

/***/ }),

/***/ "../../../../../src/app/order.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return Order; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__order_product__ = __webpack_require__("../../../../../src/app/order-product.ts");

var Order = (function () {
    function Order() {
        this._orderProducts = [];
    }
    Order.prototype.totalAllOrder = function () {
        return this._orderProducts.reduce(function (tot, currentOrder) { return tot + currentOrder.total(); }, 0);
    };
    Order.prototype.indexOf = function (product) {
        var products = this._orderProducts.map(function (orderProduct) { return orderProduct.product; });
        for (var i = 0; i < products.length; i++) {
            if (products[i].name === product.name)
                return i;
        }
        return -1;
    };
    Order.prototype.contains = function (product) {
        return this.indexOf(product) !== -1;
    };
    Order.prototype.addOrChangeQuantityProduct = function (product, quantity) {
        if (quantity === void 0) { quantity = 0; }
        if (!this.contains(product)) {
            this.addProduct(product);
        }
        this.editQuantityProduct(product, quantity);
    };
    Order.prototype.addProduct = function (product) {
        this._orderProducts.push(new __WEBPACK_IMPORTED_MODULE_0__order_product__["a" /* OrderProduct */](product));
    };
    Order.prototype.incrQuantityProduct = function (product) {
        this.editQuantityProduct(product, 1);
    };
    Order.prototype.decrQuantityProduct = function (product) {
        this.editQuantityProduct(product, -1);
    };
    Order.prototype.editQuantityProduct = function (product, quantityToAddOrRemove) {
        var indexProduct = this.indexOf(product);
        var orderProductSelected = null;
        if (indexProduct === -1) {
            return;
        }
        orderProductSelected = this._orderProducts[indexProduct];
        orderProductSelected.relativeModificationQuantity(quantityToAddOrRemove);
        this.checkIfNoProductsWith0QuantityExists();
    };
    Object.defineProperty(Order.prototype, "orderProducts", {
        get: function () {
            return this._orderProducts;
        },
        enumerable: true,
        configurable: true
    });
    Order.prototype.applyVariationToStockAllProducts = function () {
        this
            ._orderProducts
            .map(function (orderProduct) { return orderProduct.product; })
            .forEach(function (product) { return product.updateStockWithVariation(); });
    };
    Order.prototype.checkIfNoProductsWith0QuantityExists = function () {
        this._orderProducts = this.orderProducts.filter(function (orderP) { return orderP.quantity !== 0; });
    };
    Order.prototype.isEmpty = function () {
        return this._orderProducts.length === 0;
    };
    return Order;
}());

//# sourceMappingURL=order.js.map

/***/ }),

/***/ "../../../../../src/app/product.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return Product; });
var Product = (function () {
    function Product(name, price, stock, urlImage, promo, categorie) {
        if (name === void 0) { name = ''; }
        if (price === void 0) { price = 0; }
        if (stock === void 0) { stock = 0; }
        if (urlImage === void 0) { urlImage = ''; }
        if (promo === void 0) { promo = 0; }
        if (categorie === void 0) { categorie = ''; }
        this._name = name;
        this._price = price;
        this._stock = stock;
        this._urlImage = urlImage;
        this._promo = promo;
        this._categorie = categorie;
    }
    Product.prototype.isOutOfStock = function () {
        return this.stock === 0 && this.variationStock === 0;
    };
    Product.prototype.getCleanDataForSending = function () {
        var jsonToSend = {
            'Label_Prod': this._name,
            'Prix_Prod': this._price,
            'Qte_Prod': this._stock,
            'UrlImage_prod': this._urlImage,
            'Promo_Prod': this._promo,
            'Categorie_Prod': this._categorie
        };
        if (this._id !== -1) {
            jsonToSend['Id'] = this._id;
        }
        return jsonToSend;
    };
    Product.prototype.warningNotDone = function () {
        if (this._stock === 0) {
            return 'No stock';
        }
        return '';
    };
    Product.fromJSONs = function (rawsProduct) {
        return rawsProduct.map(Product.fromJSON);
    };
    Product.fromJSON = function (rawProduct) {
        var tmpProduct = new Product(rawProduct["Label_Prod"], rawProduct["Prix_Prod"], rawProduct["Qte_Prod"], rawProduct["UrlImage_Prod"], rawProduct["Promo_Prod"], rawProduct["Categorie_Prod"]);
        tmpProduct._id = rawProduct["Id_Prod"];
        return tmpProduct;
    };
    Product.prototype.editRelativeVariationStock = function (value) {
        this.variationStock += value;
    };
    Product.prototype.decrVariation = function () {
        this._variationStock--;
    };
    Product.prototype.incrVariation = function () {
        this._variationStock++;
    };
    Product.prototype.updateStockWithVariation = function () {
        this.stock = this.stockAvailable();
        this._variationStock = 0;
    };
    Product.prototype.stockAvailable = function () {
        return this.stock - this.variationStock;
    };
    Product.prototype.isAvailable = function () {
        return this.stockAvailable() > 0;
    };
    Product.prototype.canBeSubtracted = function () {
        return this.variationStock > 0;
    };
    Object.defineProperty(Product.prototype, "name", {
        get: function () {
            return this._name;
        },
        set: function (value) {
            this._name = value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Product.prototype, "price", {
        get: function () {
            return this._price;
        },
        set: function (value) {
            this._price = (value < 0) ? 0 : value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Product.prototype, "stock", {
        get: function () {
            return this._stock;
        },
        set: function (value) {
            this._stock = (value < 0) ? 0 : value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Product.prototype, "variationStock", {
        get: function () {
            return this._variationStock;
        },
        set: function (value) {
            this._variationStock = value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Product.prototype, "urlImage", {
        get: function () {
            return this._urlImage;
        },
        set: function (value) {
            this._urlImage = value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Product.prototype, "id", {
        get: function () {
            return this._id;
        },
        set: function (value) {
            this._id = value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Product.prototype, "promo", {
        get: function () {
            return this._promo;
        },
        set: function (value) {
            this._promo = value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Product.prototype, "categorie", {
        get: function () {
            return this._categorie;
        },
        set: function (value) {
            this._categorie = value;
        },
        enumerable: true,
        configurable: true
    });
    return Product;
}());

//# sourceMappingURL=product.js.map

/***/ }),

/***/ "../../../../../src/app/produit-manager.service.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ProduitManagerService; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_common_http__ = __webpack_require__("../../../common/@angular/common/http.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var ProduitManagerService = (function () {
    function ProduitManagerService(http) {
        this.http = http;
    }
    ProduitManagerService.prototype.getAllProduit = function () {
        return this.http.get('http://localhost:59583/api/produit');
    };
    ProduitManagerService.prototype.createProduct = function (product) {
        return this.http
            .post('http://localhost:59583/api/produit', product.getCleanDataForSending());
    };
    ProduitManagerService.prototype.deleteProduct = function (id) {
        return this.http.delete('http://localhost:59583/api/produit', {
            params: new __WEBPACK_IMPORTED_MODULE_1__angular_common_http__["c" /* HttpParams */]().set('id', id + '')
        });
    };
    ProduitManagerService.prototype.updateProduct = function (product) {
        return this.http.put('http://localhost:59583/api/produit', product.getCleanDataForSending());
    };
    return ProduitManagerService;
}());
ProduitManagerService = __decorate([
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["B" /* Injectable */])(),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__angular_common_http__["a" /* HttpClient */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_common_http__["a" /* HttpClient */]) === "function" && _a || Object])
], ProduitManagerService);

var _a;
//# sourceMappingURL=produit-manager.service.js.map

/***/ }),

/***/ "../../../../../src/environments/environment.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return environment; });
// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.
// The file contents for the current environment will overwrite these during build.
var environment = {
    production: false
};
//# sourceMappingURL=environment.js.map

/***/ }),

/***/ "../../../../../src/main.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
Object.defineProperty(__webpack_exports__, "__esModule", { value: true });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_platform_browser_dynamic__ = __webpack_require__("../../../platform-browser-dynamic/@angular/platform-browser-dynamic.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__app_app_module__ = __webpack_require__("../../../../../src/app/app.module.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__environments_environment__ = __webpack_require__("../../../../../src/environments/environment.ts");




if (__WEBPACK_IMPORTED_MODULE_3__environments_environment__["a" /* environment */].production) {
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["_20" /* enableProdMode */])();
}
Object(__WEBPACK_IMPORTED_MODULE_1__angular_platform_browser_dynamic__["a" /* platformBrowserDynamic */])().bootstrapModule(__WEBPACK_IMPORTED_MODULE_2__app_app_module__["a" /* AppModule */])
    .catch(function (err) { return console.log(err); });
//# sourceMappingURL=main.js.map

/***/ }),

/***/ 0:
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__("../../../../../src/main.ts");


/***/ })

},[0]);
//# sourceMappingURL=main.bundle.js.map