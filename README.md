Bu proje, C# programlama dili kullanılarak geliştirilmiş bir kaydırma bulmacası çözücüsüdür. A* algoritması kullanılarak bulmacanın başlangıç konfigürasyonundan hedef konfigürasyonuna en kısa yolu bulmaya çalışır ancak bulunan yolun en kısa yol olduğunun grantisi yoktur bulunan çözümden ve farklı çözümler mevcut olabilir.

# AStar 
A* (AStar) algoritması, başlangıç ve hedef durumlarını içeren bir graf veya ağaç yapısında en kısa yolu bulmak için kullanılan bir arama algoritmasıdır. Bu algoritma, her adımda mevcut durumun maliyetini (G) ve hedefe olan tahmini maliyetini (H) toplayarak toplam maliyeti (F = G + H) hesaplar. A* algoritması, bu toplam maliyeti en küçük olan düğümü seçerek genişleme yapar ve hedefe ulaşana kadar devam eder. Bu şekilde, en verimli yolu bulurken hem mevcut maliyeti hem de hedefe olan tahmini maliyeti dikkate alır, bu da onu geniş bir uygulama alanında etkili kılar.

# Sliding Puzzle Çözücü
A* algoritması, kaydırma bulmacasını çözerken başlangıç ve hedef durumları arasındaki en kısa yolun bulunmasına odaklanır. Kaydırma bulmacası, bir matris içindeki sayıların sıralı olmayan bir düzende yer almasıyla oluşur ve bir boş hücrenin diğer hücrelerle yer değiştirmesiyle sıralı bir duruma getirilmesi amaçlanır. A* algoritması bu bulmacayı çözmek için her adımda mevcut durumu değerlendirir, komşu durumları inceleyerek en uygun olanı seçer ve hedefe ulaşmak için en verimli yolu bulmaya çalışır. Bu süreçte, her bir durumun maliyeti (adım sayısı) ve hedefe olan tahmini maliyeti (Manhattan mesafesi gibi) dikkate alınır. A* algoritması, bu maliyetlerin toplamını minimize ederek en kısa yolun bulunmasını sağlar. Bu şekilde, kaydırma bulmacasının karmaşık düzenlerini etkili bir şekilde çözebilir ve başlangıçtan hedefe giden en kısa yolu belirler.

# Kullanım Adımları
Başlangıç ve Hedef Durumları Belirleme: İlk olarak, başlangıç ve hedef durumlarını belirlemelisiniz. Bu durumlar, matris formunda girilir.

Başlangıç Durumu Oluşturma: Başlangıç durumunu rastgele oluşturmak için "Rastgele Başlangıç" düğmesine tıklayabilirsiniz.

Hedef Durumu Oluşturma: Başlangıç durumuna uygun bir hedef durumu oluşturmak için "Hedef Oluştur" düğmesine tıklayabilirsiniz.

Arama İşlemini Başlatma: "Hesapla" düğmesine tıklayarak A* algoritmasını başlatabilirsiniz.

Çözümü İzleme: Bulmacanın çözümünü adım adım izlemek için sağ taraftaki listbox a bakabilirsiniz.

# Fonksiyonlar
AStar Fonksiyonu:
Bu fonksiyon, başlangıç durumundan hedef duruma giden yol üzerindeki tüm durumları hesaplar ve bulunan yolun bir listesini döndürür. Her bir durum bir 2D int dizisidir.

CalculateHeuristic Fonksiyonu
Bu fonksiyon iki matris arasındaki Manhattan mesafesini hesaplar. Manhattan mesafesi, iki nokta arasındaki yatay ve dikey mesafelerin toplamıdır. Bu fonksiyon, her düğümün maliyetini belirler.
İki durum arasındaki Manhattan mesafesini döndürür.

GetNeighborStates Fonksiyonu
Bu fonksiyon, bir düğümün komşu durumlarını elde eder. Her bir komşu durum, mevcut durumdan bir hareketle elde edilir. Bu fonksiyon, bulmacanın çözümü için olası adımları belirler.
Belirtilen düğümün komşu durumlarının bir listesini döndürür. Her bir durum bir 2D int dizisidir.

ReconstructPath Fonksiyonu
Bu fonksiyon, A* algoritmasının çözüm yolunu yeniden oluşturur. Bu fonksiyon, başlangıç durumundan hedef duruma giden yolu temsil eden bir liste döndürür.
Bu fonksiyon, başlangıç durumundan hedef duruma giden yolu temsil eden bir liste döndürür. Her bir eleman bir 2D int dizisidir.

# Sonuç bulunamaması ve Optimizasyon 
Bazı çözümler algoritmanın hesaplaması için çok zor ve zaman alıcı olabilir. Özellikle 3x3 boyutunun üzerindeki matrislerde düğüm sayıları milyonları geçebilir. Bunun için k değişkeni düğüm sayısını takip ederek 150.000 düğüm üzerine çıkılırsa başarısız bir sonuç döndürür ve fonksiyonu sonlandırır.  

Uygulamanın daha hızlı çözüme ulaşması için özncelikli kuyruk gibi özellikler ekleyerek kodu optimize edebilirsiniz.

# AStar Nasıl İlerler ve Düğüm Yapısı Nasıl Görünür
![image](https://github.com/Developper2310/213301069_Sliding-Puzzle-AStar/assets/130366798/46ffab09-5c6c-4677-ad98-0d9e57d17c50)

![image](https://github.com/Developper2310/213301069_Sliding-Puzzle-AStar/assets/130366798/76c9757f-19f6-4da5-b6c9-86d3f9193f8d)

