import {Component, Input, Self} from "@angular/core";
import {ControlValueAccessor, NgModel} from "@angular/forms";

@Component({
    selector: "ba-multi-checkbox[ngModel]",
    templateUrl: "./baMultiCheckbox.html",
    styleUrls: ["./baMultiCheckbox.scss"],
    providers: [NgModel]
})
export class BaMultiCheckbox implements ControlValueAccessor {
    @Input()
    baMultiCheckboxClass: string;
    @Input()
    propertiesMapping: any;

    model: NgModel;
    state: boolean;

    public constructor(@Self() state: NgModel) {
        this.model = state;
        state.valueAccessor = this;
    }

    getProp(item: any, propName: string): string {
        const prop = this.propertiesMapping[propName];
        if (!prop) {
            return item[propName];
        } else if (typeof prop === "function") {
            return prop(item);
        }
        return item[prop];
    }

    onChange(value: any): void {}

    onTouch(value: any): void {}

    writeValue(state: any): void {
        this.state = state;
    }

    registerOnChange(fn: any): void {
        this.onChange = function(state: boolean) {
            this.writeValue(state);
            this.model.viewToModelUpdate(state);
        };
    }

    registerOnTouched(fn: any): void { this.onTouch = fn; }
}