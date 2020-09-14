# BasicApp
Temel düzeyde; Katmanlı mimari yapısı ile oluşturulmuş E-Ticaret projesi

# Giriş

Proje; Bussines, DataAccess, Entites, WebUI olmak üzere 4 ana katmana ayrılmıştır. <br/>

 **Bussines Katmanında**; WebUI ile haberleşecek service interfaceleri ve bu serviceler için concrate sınıflar oluşturulmuştur. <br/>

**DataAccess Katmanında**; kullanılacak her veritabanı yapısına uygun olması için DAL interfaceleri ve concrate sınıflar oluşturulmuştur. (EFCore) <br/>

**Entites Katmanında**; veritabanı nesnelerine karşılık gelecek sınıflar oluşturulmuştur.<br/>

**WebUI Katmanında**; gerekli katmanlar ile haberleşerek kullanıcı arayüzleri oluşturulmuştur.<br/>

Proje SOLID prensiplerine uygun şekilde kodlanmıştır. <br/>

Proje geliştirilirken; Repository, dependency injection design pattern'lerinden faydalanılmıştır.

# Kurulum

**DataAccess Katmanı Üzerinde** <br/>
`dotnet ef database update` komutu ile bekleyen migrationlar veritabanına yansıtılır.
