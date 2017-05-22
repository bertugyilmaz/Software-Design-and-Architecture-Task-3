# Software-Design-and-Architecture-Task-3

Geliştirdiğiniz bir yazılımda görsel kullanıcı arayüzünde çeşitli pencereler kullandığınızı varsayın. Bir pencere temel 
haliyle çerçevesiz, beyaz bir dikdörtgenden ibarettir. Kullanıcınızın tercihlerine bağlı olarak pencerelerin şu opsiyonel 
görsel özellikleri istenilen kombinasyonda sunabilmesi gerektiğini düşünün:

- Pencerenin başlığı olabilir
- Pencerenin kenarlarında çerçeve olabilir
- Arkaplan resmi olabilir
- Arkaplan rengi olabilir
- Pencerenin gölgesi olabilir
- Pencere içeriğini göstermeyi kolaylaştırmak için düşey scroll-bar bulunabilir
- Pencere içeriğini göstermeyi kolaylaştırmak için yatay scroll-bar bulunabilir

Tüm bu seçeneklerin farklı kombinasyonlarından oluşan pencereler yapabilmek istediğimize göre bu tasarım problemine en uygun 
çözümün Dekoratör tasarım kalıbını kullanmak olduğunu düşünüyoruz. Pencereler, aşağıdaki UML şemasında verilen soyut Window 
sınıfından türemelidir. Bu sınıftaki Paint() metodu, ilgili pencerenin ekrana çizilmesinden sorumludur. Dekoratörlerdeki 
Paint() metodunda ilgili pencerenin tüm dekorasyonuyla ekrana çizilmesi eksiksiz ve doğru bir şekilde gerçekleşmelidir. Bu 
çizim işlemini simüle edecek şekilde bu metodları oluşturmanız beklenmektedir. Yani, pencerede çerçeve dekorasyonu bulunacaksa 
ekrana en azından “çerçeve çizildi” vb. bir yazı yazılmalı. 
Ayrıca, dekoratör sınıflarına anlamlı isimler vermeyi unutmayın.


><img width="350" alt="screen shot 2017-05-22 at 6 58 11 pm" src="https://cloud.githubusercontent.com/assets/23179810/26317584/a820d60e-3f20-11e7-8852-a9dc71cdb96f.png">


1. Tasarımınızın ayrıntılı UML sınıf diyagramını çizin ve Dekoratör tasarım kalıbını nasıl kullandığınızı (nasıl yararlandığınızı) 
açıklayın.Dekoratör tasarım kalıbıyla ilgili ansiklopedik bilgiyle raporunuzu doldurmayın.
2. Tasarımınızı Java veya C# dilinde kodlayın. Tasarımı örnekleyen client kodlarını yazmayı unutmayın. Çalışan programınızdan çıktılar 
ekleyerek tasarımınızın doğru olduğunu ve tasarımınızı doğru kodladığınızı gösterin.
