# CQRS & Mediator İle Jadoo Travel Projesi
### Projemizde CQRS Design Pattern ve MediatR kütüphanesiyle entegre edilmiş Mediator Design mimarisini kullandık.

🟢 Rotaları detaylı bir şekilde listeledik ve her bir rotaya özel detay sayfaları oluşturduk.

🟢 Admin panelinde site içinde gerçekleştirilen tüm CRUD işlemlerini CQRS ve MediatR kullanarak optimize ettik.

🟢 Her bir entity için özgün metodlar geliştirerek, veri erişimini ve iş mantığını daha etkili bir şekilde yönetebildik.

🟢 Veri eşleme işlemleri için AutoMapper kütüphanesinden faydalandık, böylece veri transferini ve dönüşümünü daha verimli hale getirdik.

🟢 Kodları daha anlaşılır kılmak için projeyi ViewComponent'ler aracılığıyla bileşenlere ayırdık ve modüler bir yapı sağladık.

🟢 Veritabanı yapılandırmasını Code First yaklaşımıyla gerçekleştirdik, bu sayede veritabanı modelimizi uygulama kodlarımıza uygun olarak dinamik olarak oluşturduk.

➥ Bu yaklaşımlar sayesinde projemizi hem teknik olarak zenginleştirdik hem de kod kalitesini ve sürdürülebilirliğini artırdık.

## Proje Mimarisi ve Kullanılan Teknolojiler
Bu projede modern yazılım geliştirme teknikleri ve araçları kullanılarak, sağlam, sürdürülebilir ve modüler bir mimari oluşturulmuştur. Aşağıda, projenin mimarisi ve kullanılan teknolojiler detaylı bir şekilde açıklanmıştır:

### Proje, katmanlı bir mimariye sahiptir ve aşağıdaki ana bileşenlerden oluşmaktadır:

➥ Areas: 

- Controllers: Admin paneline ait kontrolörlerin bulunduğu klasördür.
- Data: Admin paneline özgü veri modellerinin tutulduğu klasördür.
- Models: Admin paneli için kullanılan modellerin bulunduğu klasördür.
- Views: Admin paneline ait görünümlerin (view) yer aldığı klasördür.

_ViewImports.cshtml: View’lar için ortak kullanılan direktiflerin bulunduğu dosyadır.

➥ Controllers:

- DefaultController.cs
- DestinationController.cs
- UILayoutController.cs
- Bu kontrolörler, uygulamanın genel kullanıcı arayüzüne ve işlevlerine hitap eden kontrolleri içerir.

➥ DataAccess:

- Veri erişim katmanında, veritabanı işlemlerinin gerçekleştirildiği ve veriye erişim metodlarının bulunduğu klasördür.

➥ Extensions:

- ServiceExtension.cs: Uygulama genelinde kullanılan servislerin genişletildiği ve konfigüre edildiği dosyadır. Handlerlarımı burada konfigure ettim. Böylelikle Program.cs de yer kaplamadı ve solid prensiplerine uygun bir clean kod yöntemi kullanılmış oldu.

➥ Features:

-  CQRS
- - Commands: Veritabanı üzerinde değişiklik yapan işlemlerin (insert, update, delete) komut sınıfları.

- - Handlers: CQRS komutlarını işleyen sınıflar.

- - Queries: Veri çekme işlemlerini gerçekleştiren sorgu sınıfları.

- - Results: Sorguların ve komutların sonuçlarının tutulduğu sınıflar.

- Mediator

- - Commands: MediatR kütüphanesi ile kullanılan komut sınıfları.

- - Handlers: MediatR komutlarını işleyen sınıflar.

- - Queries: MediatR sorgu sınıfları.

- - Results: MediatR işlemlerinin sonuçlarını tutan sınıflar.


➥ Mapping:

- AutoMapperConfig.cs: AutoMapper konfigürasyonunun yapıldığı dosyadır.


➥ ViewComponents:

- Projeye ait ViewComponent’lerin yer aldığı klasördür. Bu bileşenler, uygulamanın farklı bölümlerinde tekrar kullanılabilir view logic’leri içerir.


➥ Views: 

- Uygulamanın genel kullanıcı arayüzüne ait view dosyalarının bulunduğu klasördür.


### 🟢 Kullanılan Teknolojiler:

📌 CQRS (Command Query Responsibility Segregation): Komut ve sorgu işlemlerini ayırarak, veri mutasyonlarını ve okuma işlemlerini farklı katmanlarda gerçekleştirmeyi sağlar. Bu projede, tüm CRUD işlemleri için CQRS pattern’i kullanılmıştır.

📌 MediatR: Mediator design pattern’ini uygulamak için kullanılan bir kütüphanedir. Bu proje, komut ve sorgu işlemlerini MediatR ile yöneterek, kodun daha modüler ve test edilebilir olmasını sağlamaktadır.

📌 AutoMapper: Nesneler arası veri dönüşümlerini (mapping) kolaylaştıran bir kütüphanedir. Projede, veri transfer objeleri (DTO) ile veri modelleri arasındaki dönüşümler AutoMapper ile gerçekleştirilmiştir.

📌 Entity Framework Core: Veritabanı işlemlerini yönetmek için kullanılan bir ORM (Object-Relational Mapping) aracıdır. Bu projede, Code First yaklaşımı benimsenmiştir, yani veritabanı yapıları C# sınıflarından türetilmiştir.

📌 ASP.NET Core MVC: Uygulamanın web arayüzünü oluşturmak için kullanılan framework’tür. MVC (Model-View-Controller) pattern’ini kullanarak, kullanıcı arayüzü ile iş mantığını ayrıştırmıştır.

📌 ViewComponents: ASP.NET Core’un tekrar kullanılabilir view logic’lerini oluşturmak için sağladığı bir özelliktir. Projede, belirli UI bileşenleri ViewComponent’ler ile modüler hale getirilmiştir.


## Proje Görselleri ve Açıklamaları

### UI Görünüm:

![defaultfeature1](https://github.com/user-attachments/assets/6193fbcd-29e2-4144-af17-7c34966a7432)

-------------------------------------------------------------------------------------------------------------------

![defaultservice](https://github.com/user-attachments/assets/cd02668d-2a83-4559-9210-2e69380105d6)

-------------------------------------------------------------------------------------------------------------------

![defaultdestinations](https://github.com/user-attachments/assets/9419cde4-27bd-4f41-864c-f4618a9c35e8)

📌 Veriler, her bir entity'e özgü metodlar yazılarak ve CQRS pattern kullanılarak listelenmiştir.

📌 Kullanıcılar, istedikleri rotanın resmine tıklayarak ilgili rota detay sayfasına kolayca erişim sağlayabilmektedir.

-------------------------------------------------------------------------------------------------------------------
![defaultmanuel](https://github.com/user-attachments/assets/2cadbd2a-2911-416e-85f8-7c44f82f3cf6)

#### 📌 Kullanıcılar buradan da son eklenen rotanın detay sayfasına gidebilirler.
-------------------------------------------------------------------------------------------------------------------

![defaulttestimonial](https://github.com/user-attachments/assets/6198a9c5-53ad-441b-9a50-c06dfb3dee6b)

-------------------------------------------------------------------------------------------------------------------

![defaultBrand](https://github.com/user-attachments/assets/356e8203-9e0b-4b3b-b3f9-ed00489db945)


-------------------------------------------------------------------------------------------------------------------

![defaultnews](https://github.com/user-attachments/assets/2170aeac-c64b-452b-b130-b28db64ff631)

-------------------------------------------------------------------------------------------------------------------

![defaultDestinationDetail1](https://github.com/user-attachments/assets/aed874f6-5b77-4342-9291-c394b18afd00)


![defaultDestinationDetail2](https://github.com/user-attachments/assets/d3c5c1a7-306b-48d7-885f-44a9188d84dd)

-------------------------------------------------------------------------------------------------------------------

![defaultgetalldestination](https://github.com/user-attachments/assets/73247df3-255c-49ac-a156-9734f7c57078)

-------------------------------------------------------------------------------------------------------------------

Admin Görünüm:

![admindashboard](https://github.com/user-attachments/assets/05d56b25-9f21-4771-ad38-2269d74c1676)

-------------------------------------------------------------------------------------------------------------------

![adminbrand](https://github.com/user-attachments/assets/edda116b-f837-4894-94f0-1524eb367009)

-------------------------------------------------------------------------------------------------------------------

![adminFeature](https://github.com/user-attachments/assets/3c67e991-0d20-4ef1-870c-1a792c8604ea)

-------------------------------------------------------------------------------------------------------------------

![adminDestinations](https://github.com/user-attachments/assets/36dba145-aefc-464a-92fc-5892e53d39e8)

-------------------------------------------------------------------------------------------------------------------

![adminManuel](https://github.com/user-attachments/assets/b9872f65-ee2f-42a8-9a59-19d224868349)

-------------------------------------------------------------------------------------------------------------------

![adminService](https://github.com/user-attachments/assets/16ca7a14-c2e8-4321-a817-9914c78edcc3)

-------------------------------------------------------------------------------------------------------------------

![adminTestimonial](https://github.com/user-attachments/assets/ffc4eab5-ed65-4b78-a987-1127e47dfa5a)

-------------------------------------------------------------------------------------------------------------------

![adminNews](https://github.com/user-attachments/assets/97aa9bd1-1a77-4a21-9eea-ff6a12af0127)





