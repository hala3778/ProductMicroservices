# 📄 Product Microservice –معلومات للطالب رقم 4


عشان تشغل مشروع Product Microservice، اتبع الخطوات التالية:


1. استنساخ المشروع من GitHub:

git clone https://github.com/hala3778/ProductMicroservice.git

2. الدخول إلى مجلد المشروع:

cd ProductMicroservice

3. الدخول إلى مجلد الخدمة:

cd Services/ProductService

4. استعادة الحزم:

dotnet restore

5. بناء المشروع:

dotnet build

6. إنشاء قاعدة البيانات (SQLite):

dotnet ef database update

(إذا ظهر خطأ أن dotnet ef غير موجود، نفذ أولاً: dotnet tool install --global dotnet-ef)

7. تشغيل المشروع:

dotnet run --urls="http://localhost:5016"

8. فتح Swagger في المتصفح:

http://localhost:5016/swagger

---



## 1. معلومات عامة عن الخدمة

| العنصر | التفاصيل |
|--------|----------|
| **اسم الخدمة** | Product Microservice |
| **رقم الميناء (Port)** | `5016` |
| **المسار الأساسي (Base Path)** | `/api/Products` |
| **نوع المعرف (ID)** | `int` (رقم صحيح) |
| **لغة التطوير** | C# / .NET 8 |
| **نوع قاعدة البيانات** | SQLite (ملف محلي) |
| **اسم ملف قاعدة البيانات** | `ProductDB.db` |
| **طريقة التشغيل** | `dotnet run --urls="http://localhost:5016"` |

---

## 2. قائمة المسارات (Endpoints)

| الطريقة (Method) | المسار (Endpoint) | الوظيفة |
|------------------|-------------------|----------|
| `GET` | `/api/Products` | جلب جميع المنتجات |
| `GET` | `/api/Products/{id}` | جلب منتج حسب المعرف (ID) |
| `POST` | `/api/Products` | إضافة منتج جديد |
| `PUT` | `/api/Products/{id}` | تحديث منتج موجود |
| `DELETE` | `/api/Products/{id}` | حذف منتج حسب المعرف (ID) |

---

## 3. نموذج البيانات (JSON Schema)

### ➤ عند الإضافة (POST / PUT)

```json
{
  "productName": "string",
  "description": "string",
  "price": number,
  "quantity": number
}
