# AStar 
Bu proje, C# programlama dili kullanılarak geliştirilmiş bir kaydırma bulmacası çözücüsüdür. A* algoritması kullanılarak bulmacanın başlangıç konfigürasyonundan hedef konfigürasyonuna en kısa yolu bulmaya çalışır ancak bulunan yolun en kısa yol olduğunun grantisi yoktur bulunan çözümden ve farklı çözümler mevcut olabilir. 

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
