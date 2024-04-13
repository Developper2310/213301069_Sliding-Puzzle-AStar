Bu proje, C# programlama dili kullanılarak geliştirilmiş bir kaydırma bulmacası çözücüsüdür. A* algoritması kullanılarak bulmacanın başlangıç konfigürasyonundan hedef konfigürasyonuna en kısa yolu bulmaya çalışır. 

# Kullanım Adımları
Başlangıç ve Hedef Durumları Belirleme: İlk olarak, başlangıç ve hedef durumlarını belirlemelisiniz. Bu durumlar, matris formunda girilir.
Başlangıç Durumu Oluşturma: Başlangıç durumunu rastgele oluşturmak için "Rastgele Başlangıç" düğmesine tıklayabilirsiniz.
Hedef Durumu Oluşturma: Başlangıç durumuna uygun bir hedef durumu oluşturmak için "Hedef Oluştur" düğmesine tıklayabilirsiniz.
Arama İşlemini Başlatma: "Hesapla" düğmesine tıklayarak A* algoritmasını başlatabilirsiniz.
Çözümü İzleme: Bulmacanın çözümünü adım adım izlemek için sağ taraftaki listbox a bakabilirsiniz.AStar Fonksiyonu
Bu fonksiyon A* algoritmasının ana işlevini gerçekleştirir. A* algoritması, bir graf veya ağaç arasında en kısa yol bulmada kullanılan bir arama algoritmasıdır. Bu fonksiyon, başlangıç durumundan hedef duruma giden en kısa yolu bulur.

Parametreler
initialState: Başlangıç durumunu temsil eden bir 2D int dizisi.
goalState: Hedef durumu temsil eden bir 2D int dizisi.
Geri Dönüş Değeri
Bu fonksiyon, başlangıç durumundan hedef duruma giden en kısa yol üzerindeki tüm durumların bir listesini döndürür. Her bir durum bir 2D int dizisidir.

CalculateHeuristic Fonksiyonu
Bu fonksiyon iki matris arasındaki Manhattan mesafesini hesaplar. Manhattan mesafesi, iki nokta arasındaki yatay ve dikey mesafelerin toplamıdır. Bu fonksiyon, her düğümün maliyetini belirler.

Parametreler
currentState: Mevcut durumu temsil eden bir 2D int dizisi.
goalState: Hedef durumu temsil eden bir 2D int dizisi.
Geri Dönüş Değeri
Bu fonksiyon, iki durum arasındaki Manhattan mesafesini döndürür.

GetNeighborStates Fonksiyonu
Bu fonksiyon, bir düğümün komşu durumlarını elde eder. Her bir komşu durum, mevcut durumdan bir hareketle elde edilir. Bu fonksiyon, bulmacanın çözümü için olası adımları belirler.

Parametreler
currentState: Mevcut durumu temsil eden bir 2D int dizisi.
satır: Matrisin satır sayısı.
sutun: Matrisin sütun sayısı.
Geri Dönüş Değeri
Bu fonksiyon, belirtilen düğümün komşu durumlarının bir listesini döndürür. Her bir durum bir 2D int dizisidir.

ReconstructPath Fonksiyonu
Bu fonksiyon, A* algoritmasının çözüm yolunu yeniden oluşturur. Bu fonksiyon, başlangıç durumundan hedef duruma giden yolu temsil eden bir liste döndürür.

Parametreler
node: Son düğüm, yani hedef durumun temsil ettiği düğüm.
Geri Dönüş Değeri
Bu fonksiyon, başlangıç durumundan hedef duruma giden yolu temsil eden bir liste döndürür. Her bir eleman bir 2D int dizisidir.
