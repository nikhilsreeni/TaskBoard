import {Component} from "@angular/core";

@Component({
    selector: "validation-inputs",
    templateUrl: "./validationInputs.html",
})
export class ValidationInputs {
    checkboxModel = [
        {
            name: "Checkbox with success",
            state: false,
            class: "has-success checkbox"
        }, {
            name: "Checkbox with warning",
            state: false,
            class: "has-warning checkbox",
        }, {
            name: "Checkbox with error",
            state: false,
            class: "has-error checkbox"
        }
    ];

    checkboxPropertiesMapping = {
        model: "state",
        value: "name",
        label: "name",
        baCheckboxClass: "class"
    };

    constructor() {
    }
}