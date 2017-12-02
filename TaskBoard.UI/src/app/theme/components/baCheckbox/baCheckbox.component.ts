import {Component, Input, Self} from "@angular/core";
import {ControlValueAccessor, NgModel} from "@angular/forms";

@Component({
    selector: "ba-checkbox[ngModel]",
    styleUrls: ["./baCheckbox.scss"],
    templateUrl: "./baCheckbox.html",
    providers: [NgModel]
})
export class BaCheckbox implements ControlValueAccessor {
    @Input()
    disabled: boolean;
    @Input()
    label: string;
    @Input()
    value: string;
    @Input()
    baCheckboxClass: string;

    model: NgModel;
    state: boolean;

    public constructor(@Self() state: NgModel) {
        this.model = state;
        state.valueAccessor = this;
    }

    onChange(value: any): void {
    }

    onTouch(value: any): void {
    }

    writeValue(state: any): void {
        this.state = state;
    }

    registerOnChange(fn: any): void {
        this.onChange = function(state: boolean) {
            this.writeValue(state);
            this.model.viewToModelUpdate(state);
        };
    }

    registerOnTouched(fn: any): void {
        this.onTouch = fn;
    }
}