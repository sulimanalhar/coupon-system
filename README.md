# coupon-system
# 🏷️ Coupon System API

نظام API مبسط لإدارة الكوبونات، يهدف إلى توفير واجهات برمجية (RESTful APIs) تتيح إضافة، تعديل، عرض، وحذف الكوبونات في بيئة سهلة ومناسبة للتكامل مع تطبيقات الويب أو الجوال.

## ⚙️ المميزات الرئيسية

- إنشاء كوبون جديد مع تحديد الخصم وتاريخ الانتهاء.
- عرض جميع الكوبونات المتاحة.
- تعديل بيانات أي كوبون موجود.
- حذف كوبونات منتهية أو غير مرغوب فيها.
- التحقق من صلاحية الكوبون وتطبيقه على الطلبات.

## 🛠️ التقنية المستخدمة

- **Backend Framework:** ASP.NET Core Web API  
- **Database:** SQL Server (أو SQLite أثناء التطوير)
- **ORM:** Entity Framework Core  
- **Architecture:** RESTful API

## 📁 هيكلية المشروع
CouponAPI/
├── Controllers/
│ └── CouponsController.cs
├── Models/
│ └── Coupon.cs
├── Data/
│ └── AppDbContext.cs
├── DTOs/
│ └── CouponDto.cs
├── Program.cs
├── Startup.cs
└── README.md



## 📥 كيفية التشغيل محليًا

1. **استنساخ المشروع:**

```bash
git clone https://github.com/اسم-المستخدم/CouponAPI.git
cd CouponAPI


تهيئة قاعدة البيانات:

تأكد من وجود اتصال بقاعدة البيانات في appsettings.json.

ثم قم بتحديث قاعدة البيانات
dotnet ef database update
dotnet run

API ستكون متاحة على: https://localhost:5001/api/coupons
النظام قابل للتوسعة ليدعم أنواع خصومات مختلفة (نسبة مئوية أو مبلغ ثابت).
🧑‍💻 المطور
الاسم: [سليمان الحربي]

البريد: sulimansi582@gmail.com

GitHub: https://github.com/sulimanalhar
