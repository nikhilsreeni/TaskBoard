import {Component} from "@angular/core";
import { NgUploaderOptions } from "ngx-uploader";

@Component({
    selector: "layouts",
    templateUrl: "./layouts.html",
})
export class Layouts {

    defaultPicture = "assets/img/theme/no-photo.png";
    profile: any = {
        picture: "assets/img/app/profile/Nasta.png"
    };
    uploaderOptions: NgUploaderOptions = {
        // url: 'http://website.com/upload'
        url: "",
    };

    fileUploaderOptions: NgUploaderOptions = {
        // url: 'http://website.com/upload'
        url: "",
    };

    constructor() {
    }

    ngOnInit() {
    }
}