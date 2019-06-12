using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWork.Database;

namespace CourseWork.Model
{
    class Archive
    {
        public static List<Star_Substance> StarSubstances = new List<Star_Substance>();
        public static List<Asterism> Asterisms = new List<Asterism>();
        public static List<Discoverer> Discoverers = new List<Discoverer>();
        public static List<Substance> Substances = new List<Substance>();
        public static List<Star> Stars = new List<Star>();

        private delegate IEnumerable<ModelItem> ListGetter();
        private delegate void ListAdder(ModelItem item);
        private delegate void ListRemover(Predicate<ModelItem> filter);

        private static Dictionary<Type, ListGetter> Datas = new Dictionary<Type, ListGetter>() {
            { typeof(Star), () => Stars },
            { typeof(Asterism), () => Asterisms },
            { typeof(Discoverer), () => Discoverers },
            { typeof(Substance), () => Substances },
            { typeof(Star_Substance), () => StarSubstances }
        };

        private static Dictionary<Type, ListAdder> Adders = new Dictionary<Type, ListAdder>() {
            { typeof(Star), (item) => Stars.Add((Star)item) },
            { typeof(Asterism), (item) => Asterisms.Add((Asterism)item) },
            { typeof(Discoverer), (item) => Discoverers.Add((Discoverer)item) },
            { typeof(Substance), (item) => Substances.Add((Substance)item) },
            { typeof(Star_Substance), (item) => StarSubstances.Add((Star_Substance)item) }
        };

        private static Dictionary<Type, ListRemover> Removers = new Dictionary<Type, ListRemover>() {
            { typeof(Star), (filter) => Stars.RemoveAll(filter) },
            { typeof(Asterism), (filter) => Asterisms.RemoveAll(filter) },
            { typeof(Discoverer), (filter) => Discoverers.RemoveAll(filter) },
            { typeof(Substance), (filter) => Substances.RemoveAll(filter) },
            { typeof(Star_Substance), (filter) => StarSubstances.RemoveAll(filter) }
        };
        
        public static void Load()
        {
            StarSubstances = DbContext.Select<Star_Substance>();
            Substances = DbContext.Select<Substance>();
            Discoverers = DbContext.Select<Discoverer>();
            Asterisms = DbContext.Select<Asterism>();
            Stars = DbContext.Select<Star>();
        }

        public static List<string> Add<T>(params T[] items) where T : ModelItem, new()
        {
            List<string> IDS = new List<string>();
            foreach (T item in items)
            {
                string last = DbContext.Insert<T>(item);
                IDS.Add(last);
                Adders[typeof(T)](DbContext.Single<T>(last));
            }
            return IDS;
        }

        public static void Update<T>(T item) where T : ModelItem, new()
        {
            Datas[typeof(T)]().Single(elem => elem.GetId() == item.GetId()).CopyFrom(item);
            DbContext.Update<T>(item);
        }

        public static void Delete<T>(T item) where T : ModelItem, new()
        {
            Removers[typeof(T)](elem => elem.GetId() == item.GetId());
            DbContext.Delete<T>(item);
        }
    }
}
