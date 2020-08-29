namespace Blog.WebUI.Models
{
    public class NewsModel
    {
        /*
         "key": "0",
      "url": "https://www.sabah.com.tr/gundem/2018/09/05/tskdan-flas-aciklama-hepsi-imha-edildi",
      "description": "TSK: \\\"Irak kuzeyi Sinath-Haftanin, Zap, Hakurk ve Kandil bölgeleri ile Hakkâri/Yüksekova kırsalına 04 Eylül 2018 tarihinde düzenlenen hava harekâtı neticesinde, bölücü terör örgütü tarafından sığınak/barınak,...Devamı için tıklayınız",
      "image": "https://iasbh.tmgrup.com.tr/dff773/320/320/0/0/345/345?u=https://isbh.tmgrup.com.tr/sbh/2018/09/05/tskdan-flas-aciklama-hepsi-imha-edildi-1536125229353.jpg",
      "name": "TSK'dan flaş açıklama: Hepsi imha edildi",
      "source": "Sabah"
         */

        public string Key { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
    }
}
