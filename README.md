# SinemaSeansTakip

Bu proje, bir sinema seans takip uygulaması için bir Windows Forms uygulamasıdır. SinemaDB.db adında bir veritabanı dosyasını kullanarak sinema salonlarını, filmleri ve seansları yönetir. Proje, C# programlama dili kullanılarak Visual Studio ortamında geliştirilmiştir. Aşağıda oluşturulan sınıf ve dosyaların özellikleri açıklanmıştır:

Models: Bu klasör, proje içinde kullanılan veri modellerini içerir. Film, salon ve seans gibi temel veri yapıları bu klasör altında yer alır.
Film.cs: Film modeli ve özelliklerini belirten sınıftır.
Salon.cs: Sinema salonu modeli ve özelliklerini belirten sınıftır.
Seans.cs: Film seans özelliklerini belirten sınıftır.

Forms1.cs: Ana formun kodlarını içerir. Kullanıcı arayüzünün çoğu bu form üzerinde tasarlanmıştır. Tab Control kullanılarak farklı sekmeler arasında geçiş yapılabilir.

SinemaDB.db: Proje için kullanılan bir SQLite veritabanı dosyasıdır. Bu dosya, uygulamanın veri depolama ve yönetiminde kullanılır. Proje içindeki Models klasöründe tanımlanan veri modelleri (film, salon, seans vb.) bu veritabanında saklanır. Uygulamanın çalışma zamanında film, salon ve seans gibi verileri saklamak ve bu verilere erişmek için kullanılır.
