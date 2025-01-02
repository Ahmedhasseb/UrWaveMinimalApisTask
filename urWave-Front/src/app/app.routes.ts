import { Routes } from '@angular/router';
import { ProductComponent } from './product/product.component';
import { UpdateProductComponent } from './update-product/update-product.component';
import { AddProductComponent } from './add-product/add-product.component';

export const routes: Routes = [
    {path: '', component:ProductComponent},
    {path: 'Update/:id', component:UpdateProductComponent},
    {path: 'AddProduct', component:AddProductComponent}

];
