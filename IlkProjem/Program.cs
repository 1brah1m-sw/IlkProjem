// type safety = tip güvenliği
// do not repeat yourself = kendini tekrarlama
// değer tutucu, alias, takma isim


string KategoriEtiketi = "Kategori";
int ogrenciSayısı = 32000;
bool sistemeGirisYapmisMİ = true;

if (sistemeGirisYapmisMİ==true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}


double dolarDun = 7.35;              //ondalıklı sayı= double     tam sayı= int
double dolarBugun = 7.45;

if (dolarDun > dolarBugun)
{
    Console.WriteLine( "azalıs butonu");
}else if (dolarDun<dolarBugun)
{
    Console.WriteLine( "artıs oku");
}
else
{
    Console.WriteLine( "degismez oku");
}
    






Console.WriteLine(KategoriEtiketi);