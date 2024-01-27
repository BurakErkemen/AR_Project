# Fırat Üniversitesi Teknoloji Fakültesi Yazılım Mühendisliği Bölümünün "Yazılım Mühendisliği Güncel Konular" Dersine Yönelik Hazırlanmış Projedir 


# 1.	PROJE BİLGİLERİ

## 1.1	Proje Adı

Koşan Barbar

## 1.2	Hedef Kitle

4-6 yaş aralığındaki çocuklar

## Oyun Başlangıcı ve Öğretici Mod

Oyun, kullanıcılara iki farklı başlama seçeneği sunmaktadır: **Normal Başlangıç** ve **Öğretici Mod**.

![Giriş Sayfası](https://github.com/BurakErkemen/AR_Project/assets/84676805/59092db1-ff4e-4650-8885-c9ae9f53d8e0)

*Şekil 1: Giriş Sayfası*
- **Normal Başlangıç:** Bu seçenekle oyuncular, direkt olarak oyunun ana bölümüne başlarlar ve sayıları takip ederek eğlenceli bir deneyim yaşarlar.
  
- **Öğretici Mod:** Eğer kullanıcılar oyunu ilk defa oynuyorlarsa veya konseptlere hızlı bir şekilde aşina olmak istiyorlarsa, öğretici modu seçebilirler. Öğretici mod, sesli yönergelerle oyunculara nasıl oynanacağını anlatır ve ortalama bir dakika içinde tamamlanır.

Bu seçenekler, kullanıcıların oyunu kendi tercihlerine göre keşfetmelerini sağlar, hem hızlı bir başlangıç hem de detaylı bir öğrenme deneyimi sunar.

![Öğretici Mod Sesleri](https://github.com/BurakErkemen/AR_Project/assets/84676805/20f9e67e-ae3c-4e13-89db-9468f3bcae85)

*Şekil 2: Öğretici Mod Sesleri*

Bu resimde, projenin öğretici modunda kullanılan sesli bildirimleri görmektesiniz. Sesli yönergeler, çocuklara oyunu öğrenmeleri ve anlamaları konusunda rehberlik eder. Her bir ses, çocukları oyunun temel konseptleri hakkında bilgilendirir ve eğitim sürecini daha etkileşimli hale getirir.



## Oyun Başlangıcı: Barbarın Ardından Sayıları Görmek

Oyun başladığında, oyuncular doğrudan barbarın arkasından sayıları gördükleri etkileyici bir sahne ile karşılaşırlar.

![Oyun Başlangıcı](https://github.com/BurakErkemen/AR_Project/assets/84676805/cf91d396-fa8f-4ee0-942f-52f8ea2b8a04)

*Şekil 3: Oyun Başlangıcı*
Bu sahne, oyunculara hemen eyleme geçme fırsatı tanır ve barbarın rehberliğinde sayıları takip etme becerilerini geliştirmelerini sağlar. Oyuncular, bu eğlenceli başlangıç ​​sahnesi ile oyunun temel mekaniklerine hızlı bir şekilde adapte olabilirler.

Karakter devam ederek sesle verilen sayıya doğu koşmanız istenir. Sayıya temas durumunda yeni sayı söylenir.

# 2.	Oyun Mekanikleri

## 2.1	Sayı Yok Etme

Karakter istenilen sayıya değdiğinizde sayı yok olur ve üç saniye sonra tekrar karşımıza çıkar. Sistem tekrar aynı sayıyı oluşturmaz. 

## 3. Grafik ve Tasarım

### 3.1 3D Sayılar
Tasarım, her iki sayıdan birine farklı bir materyal eklenerek özelleştirildi. Bu yaklaşım, sayıların çekici ve dikkat çekici olmasını hedefler.

![Rakamlar](https://github.com/BurakErkemen/AR_Project/assets/84676805/ea356129-0452-497a-b51a-4cd6d1ccfeaa)  

*Şekil 4: Özelleştirilmiş 3D Sayılar*

### 3.2 Karakter Tasarımı
Oyun karakterimiz bir barbar olarak seçildi ve onun yürüme animasyonu ile duruşu, çocuklar için ilgi çekici olacak şekilde düşünüldü. Tasarım, çocuklara olumsuz etki yapmayacak bir şekilde özenle seçildi.

![Karakter Görseli](https://github.com/BurakErkemen/AR_Project/assets/84676805/108dcec7-ce85-4cef-9863-8d7c01c8f839)  

*Şekil 5: Çocuklara Uygun Barbar Karakter*

# 4. Eğitim Odaklı Özellikler

## 4.1 İleri Düzey Seviyeler
Oyun, çocukların rakamları öğrenmesini hedefleyerek geliştirilmiştir. Geliştirme aşamalarında, materyal olarak farklı renkler eklenen sayılar arasından renkleri ve tek-çift sayıları öğretmeyi amaçlamaktadır. Örnek vermek gerekirse;
"Rengi mavi olan rakamlardan hangisi tek sayıdır?" şeklinde sorular sorularak ilerleyen aşamalarda çocuğa sadece rakamları değil, aynı zamanda renk ve tek-çift durumlarını da öğretmeyi hedeflemektedir.

## 4.2 Sesli Bildirim
Rakamlar çocuğa sesli olarak söylenir. Başarılı olması durumunda tebrik veya oyun bitti şeklinde sesler de mevcuttur.

![Örnek Rakamlar](https://github.com/BurakErkemen/AR_Project/assets/84676805/0d426a39-495b-4acd-b518-424601c26839)  

*Şekil 6: Örnek Rakamlar*


# 5.	Kullanılan Yazılımlar
  Unity 3D, Vuforia AR veya ARKit kullanılarak, Unity tabanlı ARCore, Vuforia veya ARKit teknolojileri kullanılarak gerçek dünya etkileşimini destekleyecek şekilde tasarlanması amaçlanmaktadır.

# 6.  Kullanım
  Oyunun başlangıcı kullanıcı dostu bir arayüz sağlamaktadır. Hedeflenen amaca yönelik bir yol göstermektedir. Şekil-1’de göründüğü kullanıcının yapmak istediği işlem hızlıca seçebilme olanağı vermektedir.

# 7. SWOT Analizi

## 7.1 Güçlü Yönleri
- **Hedef Kitlenin Doğru Seçimi:** 4-6 yaş aralığındaki çocuklar için tasarlanmış olması, doğru bir hedef kitlenin seçilmiş olduğunu gösterir.
- **Eğitim Odaklı Özellikler:** İleri seviye seviyeler ve sesli bildirim gibi eğitim odaklı özellikler, çocukların eğitim sürecine katkıda bulunabilir.
- **Görsel Tasarım ve Animasyonlar:** 3D sayılar, karakter tasarımı ve animasyonların çocuklar için çekici olduğu düşünülmüştür.
- **Kullanıcı Dostu Arayüz:** Projenin başlangıcının kullanıcı dostu bir arayüz ile sağlanması, kullanıcıların projeyi hızlıca anlamasını kolaylaştırabilir.

## 7.2 Zayıf Yönleri
- **Platform Bağımlılığı:** Proje Unity 3D, Vuforia AR veya ARKit kullanarak geliştirilmiş olup, bu durum projenin belirli platformlara bağlı kalmasına neden olabilir.
- **Teknoloji Bağımlılığı:** Projenin gerçek dünya etkileşimini destekleyebilmek için Unity tabanlı ARCore, Vuforia veya ARKit teknolojilerini kullanıyor olması, bu teknolojilerdeki değişikliklere bağımlılığı artırabilir.

## 7.3 Fırsatlar
- **Genişleme İmkanları:** Proje, ileri seviye seviyeler ve farklı renklerle sayılar ekleyerek genişletilebilir. Bu, çocuklara matematiksel kavramları öğretme açısından yeni olanaklar sunabilir.
- **Eğitim Sektörü İçin:** Eğitim odaklı bir proje olduğundan, okullar, eğitim kurumları veya eğitim uygulamaları için iş birliği imkanları olabilir.

## 7.4 Tehditler 
- **Teknolojik Değişiklikler:** Projenin teknolojik bağlılığı, teknolojik değişikliklere hassasiyet yaratabilir. Özellikle AR teknolojilerinde yaşanan hızlı değişimler göz önüne alınmalıdır.
- **Rekabet:** Eğitim odaklı AR projeleri alanında rekabet oldukça yüksek olabilir. Bu nedenle, benzer projelerle rekabet etme stratejileri düşünülmelidir.

# 8. RAMS Tasarım İlkeleri

## 8.1 Güvenilirlik (Reliability)

**AR Projesi Güvenilirlik Tasarımı:**
- AR uygulaması, çocuklara sayıları öğretmeyi hedeflediği için sürekli ve arızasız bir performans sergilemelidir.
- Uygulamanın sayıları tanıma ve kullanıcıyla etkileşimde bulunma yeteneği güvenilir olmalıdır.
- İleri düzey seviyelerde ve farklı renklerle genişletilebilir olmalıdır.

## 8.2 Kullanılabilirlik (Availability)

**AR Projesi Kullanılabilirlik Tasarımı:**
- Oyun, kullanıcıya normal başlangıç veya öğretici mod gibi seçenekler sunarak kullanıcı dostu bir arayüz sağlar.
- Oyunun öğretici modu, çocukların hızlı bir şekilde oyunu öğrenmelerini ve anlamalarını sağlar, bu da kullanılabilirliği artırır.
- Kullanıcının istediği işlemi hızlıca seçebilmesi için giriş sayfasında anlaşılır bir düzen sağlanmıştır.

## 8.3 Bakım Yapılabilirlik (Maintainability)

**AR Projesi Bakım Yapılabilirlik Tasarımı:**
- Uygulamanın yazılım mimarisi ve kodlama standartları, bakım yapılabilirliği artırmak için düzenlenmiştir.
- Eğitim odaklı özelliklerin ve sayıların kolayca güncellenebilir olması için modüler bir yapı kullanılmıştır.
- Bakım süreçleri, olası hataların hızlı bir şekilde giderilebilmesi ve yeni özelliklerin eklenmesini kolaylaştırmak için düzenlenmiştir.

## 8.4 Güvenlik (Safety)

**AR Projesi Güvenlik Tasarımı:**
- Karakter tasarımı, çocuklara uygun bir şekilde seçilmiştir, böylece oyun olumsuz etki yapmaz.
- Sesli bildirimler, çocuklara yönergeler verirken güvenli bir öğrenme ortamı sağlamak için tasarlanmıştır.
- Teknolojik değişikliklere hassasiyet gösterilerek, projenin güvenli ve güncel kalabilmesi amaçlanmıştır.


# 9. Çalışanlar ve Sorumlulukları

## 9.1 Proje Yürütücü ve Geliştirici
- **Adı Soyadı:** Burak Furkan ERKEMEN
- **Sorumlulukları:** Projenin genel yürütülmesi, AR uygulamasının tasarımı ve geliştirmesi.

## 9.2 letişim Bilgileri
- **[E-posta](burakfurkanerkemen@gmail.com)** 
- **[LinkedIn](https://www.linkedin.com/in/burak-furkan-erkemen-706b3522b/)**
- **[GitHub](https://github.com/BurakErkemen)**

Proje üzerinde tek başına çalışan **Burak Furkan ERKEMEN**, tasarım ve geliştirme süreçlerini yönetmekte ve uygulamanın genel sorumluluğunu üstlenmektedir.

[Doküman.docx](https://github.com/BurakErkemen/AR_Project/files/14073228/Dokuman.docx) için tıklayınız.
