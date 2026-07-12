# 📄 Product Microservice –معلومات للطالب رقم 4

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
