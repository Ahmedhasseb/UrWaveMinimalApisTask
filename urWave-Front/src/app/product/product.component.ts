import { Component, OnInit } from '@angular/core';
import{ButtonModule} from 'primeng/button';
import { ProductService } from '../Services/product.service';
import { HttpClientModule, HttpParams } from '@angular/common/http';
import { TableModule } from 'primeng/table';
import { TagModule } from 'primeng/tag';
import { CommonModule } from '@angular/common';
import { ConfirmationService, MessageService } from 'primeng/api';
import { RouterLink } from '@angular/router';
import { InputTextModule } from 'primeng/inputtext';
import { FormsModule } from '@angular/forms';
import { ConfirmDialog } from 'primeng/confirmdialog';

import { ToastModule } from 'primeng/toast';
// import { ConfirmationServiceModule } from 'primeng/confirmationservice';
@Component({
  selector: 'app-product',
  standalone: true,
  imports: [ButtonModule,HttpClientModule,TableModule
    ,TagModule,
    CommonModule,
    RouterLink,
    FormsModule
    ,InputTextModule,
    ConfirmDialog,
  ToastModule],
  templateUrl: './product.component.html',
  styleUrl: './product.component.css',
  providers: [ProductService,ConfirmationService,MessageService]
  
})
export class ProductComponent implements OnInit {
  Products: any[]=[];
  MessageToast: string="";
  Search:string="";
  minPrice:number|null=null;
  maxprice:number|null=null;
  price: number=700;
  filter={
    Search:this.Search,
    MinPrice:0,
    MaxPrice:0,
  }
  showDilog: boolean = false;
constructor(public productService:ProductService,
   private confirmationService: ConfirmationService,
    private messageService: MessageService
 
  ) { } 
  ngOnInit(): void {
   this.GetAllProductsUi();
  }
  public GetAllProductsUi(){


    this.productService.GetAllProducts(this.filter).subscribe((data)=>{
      console.log(this.filter);
      this.Products=data;
    });
  }
  
  public DeleteProduct(id: any): void {
    console.log(id); // طباعة المعرف لتأكيد القيمة
    debugger; // إدراج نقطة التوقف

    this.confirmationService.confirm({
      message: 'هل أنت متأكد من حذف هذا السجل؟',
      header: 'تأكيد الحذف',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        this.productService.DeleteProduct(id).subscribe(
          (response) => {
            this.messageService.add({ severity: 'success', summary: 'حذف المنتج', detail: response.message });
            this.GetAllProductsUi(); // تحديث القائمة بعد الحذف
          },
          (error) => {
            this.messageService.add({ severity: 'error', summary: 'خطأ في الحذف', detail: error.message });
          }
        );
      },
      reject: () => {
        console.log('عملية الحذف ألغيت');
      }
    });
}

  updateFilter() {
    if (this.price <= 1500) {
      this.filter.MinPrice = this.price;
      this.filter.MaxPrice = 0;
      this.GetAllProductsUi();
      console.log(this.filter.MinPrice,"min") // افتراضياً إذا كان أقل
    } else {
      this.filter.MaxPrice = this.price;
      this.filter.MinPrice = 0;
      this.GetAllProductsUi();
      console.log(this.filter.MaxPrice,"max")
    }
    console.log(this.filter); // لعرض القيم الجديدة في الكونسول
  }
  FilterSearch(event:any){
    this.Search = event.target.value || '';
    this.filter.Search=this.Search;
    console.log(this.filter); // عرض القيم المحدثة
    this.GetAllProductsUi();
  }
  confirm2(event: Event,id:any) {
    this.showDilog=true;
    this.confirmationService.confirm({
        target: event.target as EventTarget,
        message: 'Do you want to delete this record?',
        header: 'Danger Zone',
        icon: 'pi pi-info-circle',
        rejectLabel: 'Cancel',
        rejectButtonProps: {
            label: 'Cancel',
            severity: 'secondary',
            outlined: true,
        },
        acceptButtonProps: {
            label: 'Delete',
            severity: 'danger',
        },

        accept: () => {
          this.productService.DeleteProduct(id).subscribe({
            next: (data) => {
              console.log(data);
              this.messageService.add({ severity: 'info', summary: 'Confirmed', detail: 'Record deleted' });
              this.GetAllProductsUi();

            }
          })
        },
        reject: () => {
            this.messageService.add({ severity: 'error', summary: 'Rejected', detail: 'You have rejected' });
        },
    });
}
}
