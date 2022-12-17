using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        //Farklı cache yöntemleri kullanmak için oluşturduk.
        //burda kullancağımız yöntem : InMemoryCache

        //duration : kaç dk cache durcağını söyler

        //T : list de olabilir tek data da olabilir.
        T Get<T>(string key);   // diğer türlüde yazabiliriz---->object Get(string key); 
        object Get(string key);
        void Add(string key, object value, int duration );
        bool IsAdd(string key); //istediğimiz data Cachede var mı ?
        void Remove(string key);
        void RemoveByPattern(string pattern); //herhangi verdiğimiz bi kelime başı sonu öneöli değil.bunları uçur.
    }
}
