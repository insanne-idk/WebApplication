using WebApplication6черников.Новая_папка;

namespace WebApplication6черников.reprozitoriy
{
    public class MocSeriali : Iserial
    {
        private List<Seriali> serialiList;

        public MocSeriali()
        {
            serialiList ??= new List<Seriali>();
            serialiList.Add(new() { id = 1, Name = "Первый", god = "first@first.ru" });
            serialiList.Add(new() { id = 2, Name = "Второй", god = "first@first.ru" });
            serialiList.Add(new() { id = 3, Name = "Третий", god = "first@first.ru" });
        }


        public Seriali Add(Seriali serial)


        {
            serialiList.Add(serial);
            return serial;
        }

        public Seriali Dell(int id)
        {
            var seriali = Get(id);
            serialiList.Remove(seriali);
            return seriali;
        }

        public Seriali Get(int id)
        {
            return serialiList.Where(u => u.id == id).ToList().FirstOrDefault();
        }

        public List<Seriali> GetAll()
        {
        return serialiList;  
            
        }

        public Seriali Update(Seriali seriali)
        {
            var serialibd = Get(seriali.id);
            serialiList.Remove(serialibd);
          return  Add(seriali);

        }
    }
}
