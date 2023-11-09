# 3. Sınıf Güz Dönemi Oyun Programlama Final Projem: BlowUpBox2

### Ahmet Bahadır Aksakal - Çağla Yağmur İçer

#### 20360859079

###### [Oyunu Oynamak İçin Tıklayın(https://bahadir-aksakal.itch.io/blowupboxx2)](https://bahadir-aksakal.itch.io/blowupboxx2)

1.  ### Projede Kullanılan Teknoloji Ve Diller:
    
    *   Unity - C#
      
2.  ### Nasıl Oynanır:
    
    *   Oyunun amacı, topu tüm karelere çarptırarak onları yok etmektir.
    *   Top zemine değerse 1 canınız gider. Toplam 6 canınız bulunmaktadır. Can 0 olduğunda oyunu kaybedersiniz, tüm kaydınız silinir ve oyun baştan başlar.
    *   Oyunun Pausemenü'sündeki Mainmenu butonuna bastığınız sahne save alınır. Daha sonra Mainmenüden resume butonuna tıklayarak o sahneden devam edersiniz.
    *   Sağ ve Sol yön tuşları ile playeri hareket ettirin. Sol mouse-click ile ateş edin.
    *   23 bloğu kırdığınızda 2. bölüme geçersiniz.
    *   2\. bölüme geçildiğinde can haklarınız yenilenir ve skor sıfırlanır
    *   2\. bölümdeki 23 bloğu kırdığınızda oyunu kazanırsınız.
      
3.  ### V2 Sürümü Geliştirme Notları:
    
    *   Ahmet Bahadır Aksakal - Çağla Yağmur İçer
    *   Oyun için remote çalışmak pek sağlıklı olmayacağından, oyun geliştirme sürecinde ekip arkadaşımla birlikte tek bir bilgisayar üzerinden çalıştık
    *   Projedeki tüm scriptleri ve tasarımları birlikte yaptık.
    *   İllaki bir örnek vermek gerekirse:
    
    ###### Çağla Yağmur İçer;
    
    *   Pause menü fonksiyonlarının asenkron şekilde yazılması, eski butonların opitimize edilmesi, eski buton fonksiyonlarının asenkron olarak güncellenmesi
    *   Kayıt alma(Save), fonksiyonlarının yazılması ve projeye entegre edilmesi. Oluşan yeni hataların fixlenmesi
    *   Assetlerin Krita'da hazırlanması(Kendi Çizimleri) ve projeye entegre edilmesi.
    *   Animasyonların hazırlanması ve projeye entegre edilmesi.
    *   Müzik dosyalarının hazırlanması, editlenmesi ve projeye entegre edilmesi.
    *   Yeni scriptlerin ve fonksiyonların geliştirilmesinde destek verilmesi.
    *   Sahne2'nin oluşturulması ve yeni bugların fixlemesi
    *   Tüm proje tek pc üzerinden yürütülüp aslında tüm adımlar beraber yapılmıştır.
    
    ###### Ahmet Bahadır Aksakal;
    
    *   Ana menü scripti, bu scripteki asenkron geçişler, save edilen sahnenin tespiti ve yüklenmesi (resume butonu işlevi).
    *   Sahne2'nin oluşturulması ve yeni bugların fixlemesi
    *   Menü tasarımları ve oyuna uyumlu yeni yazı tipi eklenmesi ve projeye entegre edilmesi.
    *   Restart butonlarının en baştaki sahneye geri atıyordu,Butonlar o anda oynanan sahneyi restart edecek şekilde güncellendi(Asenkron).
    *   GoNextLevel() fonksiyonu ile istenilen şekilde asenkron sahne geçileri
    *   Tüm proje tek pc üzerinden yürütülüp aslında tüm adımlar beraber yapılmıştır.
    
4.  ### V1 Sürümü Geliştirme Notları:
    
    *   Ahmet Bahadır Aksakal - Çağla Yağmur İçer
    *   Oyun için remote çalışmak pek sağlıklı olmayacağından, oyun geliştirme sürecinde ekip arkadaşımla birlikte tek bir bilgisayar üzerinden çalıştık
    *   Projedeki tüm scriptleri ve tasarımları birlikte yaptık.
    *   İllaki bir örnek vermek gerekirse: Bahadır Aksakal; oyun pause kısmı, zamanın durması, pause menüsü, getAxis yapısı üzerinden biraz daha fazla uğraşmıştır. Çağla Yağmur; top fiziği, nişangah, collision, box'lar ve rigidBody'ler üzerinde biraz daha fazla uğraşmıştır.
      
5.  ### Oyundan Görseller:
    
    *   ![](GorsellerReadme/blowupbox2-0.png)
    *   ![](GorsellerReadme/blowupbox2-1.png)
    *   ![](GorsellerReadme/blowupbox2-2.png)
    *   ![](GorsellerReadme/blowupbox2-3.png)
    *   ![](GorsellerReadme/blowupbox2-4.png)
    *   ![](GorsellerReadme/blowupbox2-5.png)
