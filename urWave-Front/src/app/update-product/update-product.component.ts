import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { ProductService } from '../Services/product.service';
import { ActivatedRoute } from '@angular/router';
import { InputTextModule } from 'primeng/inputtext';
import { HttpClientModule } from '@angular/common/http';
import { ButtonModule } from 'primeng/button';
import { MessageService } from 'primeng/api';
import { ToastModule } from 'primeng/toast';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-update-product',
  standalone: true,
  imports: [InputTextModule,ReactiveFormsModule,HttpClientModule,ButtonModule,ToastModule,CommonModule],  
  templateUrl: './update-product.component.html',
  styleUrl: './update-product.component.css',
  providers: [ProductService,MessageService]
})
export class UpdateProductComponent implements OnInit {
 DisplayImageProduct:any;
 public formGroup: FormGroup;
 OrignalValue:any;
 ProductId:any;
 isFormChanged: boolean = false;
  constructor(public _productService:ProductService,
    private _route:ActivatedRoute,
    public formbuilder:FormBuilder,
    private messageService: MessageService,
  ) 
   {
this.formGroup=this.formbuilder.group({
  name:new FormControl("",[Validators.required,Validators.maxLength(100)],) ,
  price:new FormControl("",) ,
  description:new FormControl("",[Validators.required,Validators.maxLength(500)],) ,
 
})
  
    this.ProductId= this._route.snapshot.params['id'];
   console.log(this.ProductId)
    this.GetProductById(this.ProductId);
    this.TrackFromChanges();
    

      
    
  }

  ngOnInit(): void {
    
  }
  GetProductById(id: any)
   {
    this._productService.GetProductByid(id).subscribe((data)=>{
      console.log(data);
      this.formGroup.patchValue(data);
      this.OrignalValue=this.formGroup.value

      this.isFormChanged=false;
      this.DisplayImageProduct=data.image;
      
      
    })
  }
  TrackFromChanges(){
   this.formGroup.valueChanges.subscribe(()=>{

      this.isFormChanged=JSON.stringify(this.formGroup.value)!==JSON.stringify(this.OrignalValue);
    

   });
  }

  submit():void
  {
if(!this.isFormChanged)
  {
return;
}
  
  this._productService.UpdateProduct(this.ProductId,this.formGroup.value).subscribe(({
    next:(response)=>{
      if(response.ok==200){

        this.messageService.add({severity:'success', summary: 'Proudct Update', detail: response.message});
       
      }

    },
    error:()=>{
      this.messageService.add({severity:'error', summary: 'Error', detail: 'Product Not Updated'});
    }
  }));
   
  }


}