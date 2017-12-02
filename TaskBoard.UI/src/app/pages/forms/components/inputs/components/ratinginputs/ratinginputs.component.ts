import { Component } from "@angular/core";

@Component({
    selector: "rating-inputs",
    templateUrl: "./ratinginputs.html"
})
export class Rating {
    _rate1 = 3;
    _rate2 = 4;

    _max1 = 5;
    _max2 = 10;

    constructor() {
    }

}