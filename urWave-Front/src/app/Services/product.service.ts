import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import{Observable} from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class ProductService {
private BaseUrl="https://localhost:7067/api/Products"
  constructor(private http: HttpClient) { }
GetAllProducts(paramRequest:any):Observable<any>{
  let params = new HttpParams();
  
if(paramRequest.Search)
{
  params = params.set('Search', paramRequest.Search);
}
if (paramRequest.MaxPrice) {
  params = params.set('MaxPrice', paramRequest.MaxPrice);
}
if (paramRequest.MinPrice) {
  params = params.set('MinPrice', paramRequest.MinPrice);
}
  return this.http.get(`${this.BaseUrl}/GetAllProducts`,{params});

}
DeleteProduct(id:number):Observable<any>{
  return this.http.delete(`${this.BaseUrl}/Delete/${id}`);
}
GetProductByid(id:number):Observable<any>{
  return this.http.get(`${this.BaseUrl}/GetProductByid/${id}`);
}
UpdateProduct(id:number,data:any):Observable<any>{
  return this.http.put(`${this.BaseUrl}/Update/${id}`,data);

 
}
AddToProduct(Data:any):Observable<any>{
  return this.http.post(`${this.BaseUrl}/CreateProduct`,Data);

}
}