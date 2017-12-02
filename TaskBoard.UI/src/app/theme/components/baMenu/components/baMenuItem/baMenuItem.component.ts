import {Component, Input, Output, EventEmitter} from "@angular/core";

@Component({
    selector: "ba-menu-item",
    templateUrl: "./baMenuItem.html",
    styleUrls: ["./baMenuItem.scss"]
})
export class BaMenuItem {

    @Input()
    menuItem: any;
    @Input()
    child = false;

    @Output()
    itemHover = new EventEmitter<any>();
    @Output()
    toggleSubMenu = new EventEmitter<any>();

    onHoverItem($event): void {
        this.itemHover.emit($event);
    }

    onToggleSubMenu($event, item): boolean {
        $event.item = item;
        this.toggleSubMenu.emit($event);
        return false;
    }
}