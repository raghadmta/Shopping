﻿# Shopping
 ## فكرة المشروع  
موقع يعرض منتجات أحد المحلّات (مثل: أجهزة إلكترونية، منتجات عناية بالبشرة، حدد أي نوع منتجات تريد عرضه..) ويحتوي كل منتج على التفاصيل التالية: اسم المنتج، وصف المنتج، وسعر المنتج.

المتطلبات
يحتوي هذا المشروع على المتطلبات التالية:

 - يحتوي على Controller واحد باسم Products.
 - يحتوي على  Model واحد باسم Product.
 - يحتوي على Views عددها ثلاثة كالتالي: Index و Details و Random.

## الخطوات
أولًا: تعرف مجموعة List من نوع ProductModel داخل الدالة Index.  
![image](https://github.com/raghadmta/Shopping/assets/55548241/16305ddd-c1c4-4644-bc4d-6109d8df7b88)
  
ثانيًا: يتم تمرير المجموعة إلى View باستخدام loop لعرض كل عنصر.  
![image](https://github.com/raghadmta/Shopping/assets/55548241/5702405c-2d70-4134-a849-5c73bfb6e9ce)

ثالثًا: تعرف منتج جديد في الدالة Details وتمرير القيم إلى DetailsView.  
![image](https://github.com/raghadmta/Shopping/assets/55548241/d4d9fd37-9ed1-4ac1-9946-ead978eb6e72)  


## تحدي:  

رابعًا: تمرير id في المسار path مثال: {id}/{Action}/Controller/ للدالة Details.  
![image](https://github.com/raghadmta/Shopping/assets/55548241/e981509c-e98b-4904-940c-ff1d6242c6bc)

خامسًا: إظهار العنصر الذي يحتوي على نفس Id وتمرير القيم إلى View.  
![image](https://github.com/raghadmta/Shopping/assets/55548241/13029715-aeaf-40a3-be46-a1927b7a4bc7)




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
