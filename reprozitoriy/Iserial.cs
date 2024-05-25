using WebApplication6черников.Новая_папка;

namespace WebApplication6черников.reprozitoriy
{
    public interface Iserial
    {
        public Seriali Add (Seriali seriali);
        public Seriali Get (int id);
        public Seriali Update (Seriali seriali);
        public List <Seriali> GetAll ();
        public Seriali Dell (int id);


    }
}
