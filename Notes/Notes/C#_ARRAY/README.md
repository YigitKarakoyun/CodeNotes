# ---ARRAY INDEXOF YÖNTEMİYLE ARAMA YAPMAK---

string[] AracListe = new string[] { "Opel", "Peugeot", "Mercedes", "Ferrari", "Reno", "Fiat", "Golf" };

int index = Array.IndexOf(AracListe, txt_Ara.Text);

if (index >= 0)  MessageBox.Show("Araç " + index.ToString() + ". sırada bulundu.");

else   MessageBox.Show("Aradığınız araç listede mevcut değil.");


# ---ARRAY DOĞRUSAL ARAMA---

string[] AracListe = new string[] { "Opel", "Peugeot", "Mercedes", "Ferrari", "Reno", "Fiat", "Golf" };

bool Durum = false;

for (int i = 0; i < AracListe.Count(); i++){

   if (AracListe.ToUpper() == txt_Ara.Text.ToUpper()){
   
      // büyük küçük harf farkından dolayı olsa bile yok diyeceğinden 
      
      //iki tarafıda büyük harf olarak değiştirdik.
      
      Durum = true;
      
      break;
    }
}

if (Durum == true)  MessageBox.Show("Aradığınız araç listede mevcut.");

else  MessageBox.Show("Aradığınız araç listede mevcut değil.");
