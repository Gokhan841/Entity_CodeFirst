using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Entity_CodeFirst.Entity;

namespace Entity_CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            c.Database.Create();
        }
    }
}
//1-Enity adında bir klasör açılıp Manege Nucget Packetdan entity framework indirildi
//Entitiy içine Urunler sınıfı ve context eklendi.Context sınıfı veri tabanı ile bağlantı kuran taloları oluşturan bir sınıftır.Context sınıfında usinglere system.data.enity'i eklemeyi ve dcontexten miras vermeyi unutma.
//2-App.config kısmından bağlant ayarları yapıldı.(connectionstrings etiketi ve arsındaki alan yazıldı)
//3-usinglere projeadı.entity eklenerek.Forumun load kısmında db oluşturuldu.Böylece form yüklendiği an sql de oluşturulmuş olacak

//4-Bir veri tabanı ya da tablo bir kere oluştuktan sonra onun üzerinde düzenleme(yeni bir tablo eklme, EnvironmentVariableTarget olan tabloya yeni bir sutun ekleme,sutun adı değiştime tablolar arası ilişki kurma) yapabilmek içim Migrations eklemek gerekiyor.=>View-other window-Package Maneger Console dan açılan ekrana;
//                                                         update-database(veri tabanı güncellendi)
//                                                         enable-Migrations (gelen klasorde false'u true yap)

//Yeni bir tablo eklemek için Migrations'ı kurduk zaten. Entity içine gelip sınıf ekleyip context sınıfında db set işlemini yapıyoruz. Sonrasında PM'e update-database dediğimizde ekleniyor.

//Taloları İlişkilendirmek için ilişkilendirmek istediğimiz sınıfa gidip bire çok ilişki varsa birden çok ilişki kurabilen sınıfta Icollection veya liste olarak, tek bir ilişki kurulabilen sınıfta örn:Kategori tipinde Kategori olarak kodlar yazılır. ve update-database, Database de diagrams kısmından refresh ederedrek ilişki görüleilir.Sona sql e diagram kydedilr.

//Migration ile tablo ekleme   ==> yine entity içerisine klass oluşturulup Contextte tanıtılıp Package Mange Console!a
//                                 add-migration CreateTabloadıTable 
//                                 update datase               ile ekleyeiliriz

// Migration ile var olan tabloya sütun ekleyeceksek, o tablonun oluşturuduğu sınıfa gider o sütünu ekleriz. Pmc'a 
//                                 add-migration CreateColumnSütunadıinTabloAdı  
//                                 update-databae(örn:add-migration CreateColumnKategoriDetayinKategoris)

// Eğer bir tablodaki sütun adını değiştireceksek==> o tablonun oluşturulduğu classa gider sütunadını değiştirir PMC'a
//                   RenameColumnEskiadToYeniadinTabloadı(örn:add-migratio RenameKatgoriAadtoKategoriAdinKategorilers)
//                   Sql("Update Kategorilers Set KategoriAd=KategoriAad ") 
//                   Sql("Update Kategorilers Set KategoriAad=KategoriAd "); Komutlarını migration içinde addclumn ve drop column satrları arasına ekleriz ki tablodaki verileri kaybetmeden bu değişiklik işlemini yapalım.

// Eğer bir tablodaki sütunu sileceksek ==> o tablonun oluşturulduğu classa gider sütunu siler PMC'a  
//                                 add-migration DeleteColumnKategoriDetayinKategorilersTable
//                                 update-datase

//Eğer bir tabloyu komple silmek istersek ==> Contextten gidip tabloyu sier PMC'a
//                                DeleteTabloadıTable(Örnek> add-migration DeletaMusterisTable)
