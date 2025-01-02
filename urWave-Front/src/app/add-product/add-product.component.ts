import { Component, OnInit } from '@angular/core';
import { MessageService } from 'primeng/api';


import { FormBuilder, FormGroup, Validators,ReactiveFormsModule,FormControl } from '@angular/forms';
import { InputTextModule } from 'primeng/inputtext';
import { HttpClientModule } from '@angular/common/http';
import { ButtonModule } from 'primeng/button';
import { FileUpload } from 'primeng/fileupload';
import { CommonModule } from '@angular/common';
import { ToastModule } from 'primeng/toast';
import { ProductService } from '../Services/product.service';


@Component({
  selector: 'app-add-product',
  standalone: true,
  imports: [ReactiveFormsModule,
    InputTextModule,
    HttpClientModule,
    ButtonModule,
    FileUpload,
    CommonModule,
    ToastModule

  ],
  
  templateUrl: './add-product.component.html',
  styleUrl: './add-product.component.css',
  providers: [ProductService,MessageService]
})
export class AddProductComponent implements OnInit  {


  public formGroup: FormGroup;
  selectedFile: any;
  constructor(private _productService:ProductService,
    public _messageService: MessageService,
    
    public formbuilder:FormBuilder,
  ) { 
    this.formGroup=this.formbuilder.group({
      name:new FormControl("",[Validators.required,Validators.maxLength(100)],) ,
      price:new FormControl("",[Validators.required]) ,
      description:new FormControl("",[Validators.required,Validators.maxLength(500)],) ,
      CreateAt:new FormControl("",) ,
      ImageUrl: [null, Validators.required]
    })
}
  ngOnInit(): void {
    
  }

  onFileUpload(event: any) {
    console.log('File uploaded:', event);
    const file = event.files[0]; 
    if (file) {
      this.formGroup.get('ImageUrl')?.setValue(file)
      this.selectedFile = file;

      console.log('File selected:', this.selectedFile);
    } else {
      console.error('No file selected');
    }
  }
  submit():void
  {
    if (this.formGroup.invalid || !this.selectedFile) {
      alert('Please fill all fields and select an image.');
      return;
    }

    const formData = new FormData();
    formData.append('name', this.formGroup.get('name')?.value);
    formData.append('price', this.formGroup.get('price')?.value);
    formData.append('description', this.formGroup.get('description')?.value);
    formData.append('CreateAt', this.formGroup.get('createdAt')?.value);
    formData.append('ImageUrl', this.formGroup.get('ImageUrl')?.value);
    console.log('Form data:', formData);
    this._productService.AddToProduct(formData).subscribe({
      next:(response)=> {
        if(response.ok==200){

          this._messageService.add({severity:'success', summary: 'Add Product', detail: response.message});
        }
      },
      error:(error)=> {
        this._messageService.add({severity:'error', summary: 'Error', detail: 'Product Not Add'});
      },
    })
   
    
}
  
    

  }
  

  
  

  


