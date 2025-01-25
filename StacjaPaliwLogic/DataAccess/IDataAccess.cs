namespace StacjaPaliwLogic.DataAccess
{
    public interface IDataAccess<T>
    {
        public static int _availableId { get; }
        public List<T> GetAllRows();
        public T ReadRow(int _id);
        public void AddRow(T _row);
        public void AddRows(List<T> rows);
        public void DeleteRow(int _id);
        public void Save();
    }
}
