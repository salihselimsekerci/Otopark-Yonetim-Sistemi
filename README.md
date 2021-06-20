# Otopark-Yönetim-Sistemi

UYGULAMA HAKKINDA

Projenin asıl amacı otopark giriş çıkışlarını kontrol ederek verileri kaydetmektir.
Bunun dışında müşterileri ve araçları kaydedip bunlardan istatistik, bilgi ve arşiv olarak kullanılabilir.
Dikkat: Projede silme işlemi yoktur. Bu işlemin yapılmamasının sebebi tüm verilerin sistemde saklanmasını amaçlamıştır. İleride bilinmeyen bir sebepten kaynak olarak kullanılabileceğindendir.

GİRİŞ PENCERESİ

![1](https://user-images.githubusercontent.com/53614606/122605015-88d4bf00-d07f-11eb-829c-23af78c13304.jpg)

Uygulamaya giriş yapmamızı sağlayan penceredir. Giriş işlemi yapılmadan herhangi bir işlem yapılamaz. Tasarımın amacı; Uygulamaya rastgele bir kişinin girişini engellemektir. Varsayılan Kullanıcı Adı ve Parola sırasıyla admin,123’dur.

ANAPENCERE

![2](https://user-images.githubusercontent.com/53614606/122605135-b457a980-d07f-11eb-81ad-3c3e2d9c1f44.jpg)

Ana pencere, Giriş penceresinden sonra açılan Müşteri İşlemleri, Araç İşlemleri, Otopark Giriş-Çıkış, Otopark arşiv ve İstatistik pencerelerine ulaşabileceğiniz yerdir.
Ana pencerede şu an aktif olarak otoparkta duran araçların bilgilerini gösterir bunlar yer, müşteri ve araç bilgisidir.
Menüler sayesinde daha kullanışlı bir ara yüz tasarlandı bu sayede daha fazla özellik olarak F1,F2,F3 soldan sağa doğru kısa yollar atandı.

MÜŞTERİ İŞLEMLER PENCERESİ

![3](https://user-images.githubusercontent.com/53614606/122605237-d9e4b300-d07f-11eb-9564-1e892c778584.jpg)

Müşterilerin sisteme eklendiği gerekli zaman bilgilerinin güncellendiği veya sistemden
çıkarılıp arşive eklendiği yerdir.
Bunların dışında birden fazla alanda arama yapılabildiği ve arşivlenen müşterilerin
getirilebildiği yerdir.
Arşivlenen müşteriler arşiv listesinde gözükür eğer arşivden çıkarmak istersek Müşteri
T.C Kimlik No Maske kutusuna gelerek T.C Kimlik numarasını yazarak ‘Getir’ butonu
yardımıyla arşivden çıkarabilirsiniz.

MÜŞTERİ ARŞİVİ

![4](https://user-images.githubusercontent.com/53614606/122605328-f7198180-d07f-11eb-9243-d18b418e7536.jpg)

Müşterilerin bilgilerinin sistemde gözükmediği zaman saklandığı yerdir.

ARAÇ İŞLEMLERİ PENCERESİ

![5](https://user-images.githubusercontent.com/53614606/122605465-292ae380-d080-11eb-88e2-cf2f61e271f4.jpg)

Araçların sisteme eklendiği gerekli zaman bilgilerinin güncellendiği veya sistemden
çıkarılıp arşive eklendiği yerdir.
Bunların dışında birden fazla alanda arama yapılabildiği ve arşivlenen araçların
getirilebildiği yerdir.
Arşivlenen araçlar arşiv listesinde gözükür eğer arşivden çıkarmak istersek Araç Plaka No
kutusuna gelerek plakasını yazarak ‘Getir’ butonu yardımıyla arşivden çıkarabilirsiniz.

ARAÇ ARŞİVİ

![6](https://user-images.githubusercontent.com/53614606/122605551-4790df00-d080-11eb-9cc9-2c5e323eb138.jpg)

Araçlar bilgilerinin sistemde gözükmediği zaman saklandığı yerdir.

OTOPARK GİRİŞ İŞLEMLERİ

![7](https://user-images.githubusercontent.com/53614606/122606531-be7aa780-d081-11eb-8efb-c5758da28425.jpg)

Müşteri, araç, yer ve giriş zamanı seçilerek otopark girişi yapıldığı yerdir. Eğer müşteri
veya araçlar sistemde yok ise “+” butonları yardımıyla hızlı bir şekilde ekleme yapılabilir
ve seçim işleminde uygulanabilir.

OTOPARK ÇIKIŞ İŞLEMLERİ

![8](https://user-images.githubusercontent.com/53614606/122606649-f7b31780-d081-11eb-9642-1bac031b36ee.jpg)

Ana pencere üzerindeki tablodan otoparka
giriş yapan araçlardan birisini seçerek bu
pencereyi açabiliriz. Otopark çıkış
işlemleri ana pencereden gelen bilgiye göre
veri tabanından bu yer hakkında tüm
bilgiler çekilir eğer bilgiler doğru ise
sistemden çıkarılır. Eğer araç ileri bir
saatte çıkacak ise veya geri bir saatte
çıkmış ise buna göre çıkış zamanını seçerek
ücretin düzenlenmesini sağlayabilirsiniz.

OTOPARK ARŞİV PENCERESİ

![9](https://user-images.githubusercontent.com/53614606/122606724-10bbc880-d082-11eb-95f4-4634abe215e5.jpg)

Otopark çıkış işlemlerinden çıkarılan tüm müşteri, araç ve yer bilgilerinin saklandığı yerdir.

İSTATİSTİK PENCERESİ

![10](https://user-images.githubusercontent.com/53614606/122606819-38129580-d082-11eb-9b8d-b1364aad4efa.jpg)

Kullanıcıya otoparkla ilgili belli başlı istatistik sunan penceredir.

# License
        
        MIT License

        Copyright (c) 2021 Salih Selim SEKERCI
