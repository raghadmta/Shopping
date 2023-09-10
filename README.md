# Shopping
 ## فكرة المشروع  
موقع يعرض منتجات أحد المحلّات (مثل: أجهزة إلكترونية، منتجات عناية بالبشرة، حدد أي نوع منتجات تريد عرضه..) ويحتوي كل منتج على التفاصيل التالية: اسم المنتج، وصف المنتج، وسعر المنتج.

المتطلبات
يحتوي هذا المشروع على المتطلبات التالية:

 - يحتوي على Controller واحد باسم Products.
 - يحتوي على  Model واحد باسم Product.
 - يحتوي على Views عددها ثلاثة كالتالي: Index و Details و Random.

## الخطوات
أولًا: تعرف مجموعة List من نوع ProductModel داخل الدالة Index.  
  ![Screenshot 2023-09-10 132429](https://github.com/raghadmta/Shopping/assets/55548241/bb748cbd-0a60-416f-abb9-27332881b0e3)

ثانيًا: يتم تمرير المجموعة إلى View باستخدام loop لعرض كل عنصر.  
![Screenshot 2023-09-10 132536](https://github.com/raghadmta/Shopping/assets/55548241/4fc368cd-ca57-4372-a485-0289ba85547e)

ثالثًا: تعرف منتج جديد في الدالة Details وتمرير القيم إلى DetailsView.  
![Screenshot 2023-09-10 132658](https://github.com/raghadmta/Shopping/assets/55548241/0b5145b2-c1d0-4ba6-a922-d0e6d92a4411)


## تحدي:  

رابعًا: تمرير id في المسار path مثال: {id}/{Action}/Controller/ للدالة Details.  
![Screenshot 2023-09-10 132803](https://github.com/raghadmta/Shopping/assets/55548241/a5a5cc65-e9f1-4267-9682-36b508ff257a)

خامسًا: إظهار العنصر الذي يحتوي على نفس Id وتمرير القيم إلى View.  
![Screenshot 2023-09-10 132906](https://github.com/raghadmta/Shopping/assets/55548241/b5473ad8-6f31-484a-b15b-41c7b4db35c2)




## Structure
```
./Shopping
├── controllers
        └──ProductsController
├── models
       └──ProductModel
├── views
       └──Products
            └──Index.cshtml
            └──Details.cshtml
            └──AddItem.cshtml
└── Program.cs
```
